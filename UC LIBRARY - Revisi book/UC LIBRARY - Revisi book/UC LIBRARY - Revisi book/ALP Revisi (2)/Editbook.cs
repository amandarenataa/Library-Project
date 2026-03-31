using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ALP_Revisi__2_
{
    public partial class Editbook : Form
    {

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;

        DataTable dtEditBook;
        DataTable dtAvail;
        DataTable dtUnavail;
        DataTable dtSearch;

        DataGridViewRow selectedRow;

        string idBukuKeep;
        string title3charOLD;
        string author1charOLD;
        string availableBook;

        public Editbook()
        {
            InitializeComponent();
        }

        private void updateDgv()
        {
            dtEditBook = new DataTable();
            sqlQuery = "SELECT ID_buku, ISBN_Buku, Terbitan_Buku, Judul_Buku, Penulis_Buku, Harga_Buku, Qty_Buku, Status_Avail_Buku, Status_Del_Buku from buku;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtEditBook);
            DGV_Edit.DataSource = dtEditBook;
        }

        private void Editbook_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=@RagcatsL0ve;database=indramar_20232_dbd_6");

            updateDgv();

            cb_FilterE.SelectedIndex = 0;

            bt_Edit.Enabled = false;

            tb_TitleE.MaxLength = 150;
            tb_WriterE.MaxLength = 30;
            tb_IsbnE.MaxLength = 13;
            tb_PublishE.MaxLength = 4;
            tb_PriceE.MaxLength = 9;
        }

        private void DGV_Edit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                selectedRow = DGV_Edit.Rows[e.RowIndex];

                tb_TitleE.Text = selectedRow.Cells["Judul_Buku"].Value.ToString();
                tb_WriterE.Text = selectedRow.Cells["Penulis_Buku"].Value.ToString();
                tb_IsbnE.Text = selectedRow.Cells["ISBN_Buku"].Value.ToString();
                tb_PublishE.Text = selectedRow.Cells["Terbitan_Buku"].Value.ToString();
                tb_PriceE.Text = selectedRow.Cells["Harga_Buku"].Value.ToString();

                availableBook = selectedRow.Cells["Status_Avail_Buku"].Value.ToString();

                idBukuKeep = selectedRow.Cells["ID_Buku"].Value.ToString();
                string idBuku = selectedRow.Cells["ID_Buku"].Value.ToString();
                int index_cbTopic = Convert.ToInt32(idBuku.Substring(1, 3)) - 1;
                cb_TopicE.SelectedIndex = index_cbTopic;

                string cbCategoryType = idBuku.Substring(0, 1);
                if (cbCategoryType == "A")
                {
                    rBt_fictionE.Checked = true;
                    rBt_nonFictionE.Checked = false;
                }
                else if (cbCategoryType == "B")
                {
                    rBt_fictionE.Checked = false;
                    rBt_nonFictionE.Checked = true;
                }

                title3charOLD = selectedRow.Cells["Judul_Buku"].Value.ToString().Substring(0, 3).ToUpper();
                author1charOLD = selectedRow.Cells["Penulis_Buku"].Value.ToString().Substring(0, 1).ToUpper();

            }
        }

        private void clearAll()
        {
            tb_TitleE.Text = "";
            tb_WriterE.Text = "";
            tb_IsbnE.Text = "";
            tb_PublishE.Text = "";
            tb_PriceE.Text = "";
            cb_TopicE.SelectedIndex = -1;
            rBt_fictionE.Checked = false;
            rBt_nonFictionE.Checked= false;
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            if (tb_TitleE.Text == "" || tb_WriterE.Text == "" || tb_IsbnE.Text == "" || tb_PublishE.Text == "" || tb_PriceE.Text == "" || cb_TopicE.SelectedIndex == -1 || (rBt_fictionE.Checked == false && rBt_nonFictionE.Checked == false))
            {
                MessageBox.Show("All Information Must Be Filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (title3charOLD != tb_TitleE.Text.Substring(0, 3).ToUpper() || author1charOLD != tb_WriterE.Text.Substring(0, 1).ToUpper())
            {
                MessageBox.Show("Too much change! Better to add new book rather than editing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (availableBook == "False")
            {
                MessageBox.Show("Unable to Edit Unavailable Books!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sqlQuery = $"UPDATE buku SET ISBN_Buku = '{tb_IsbnE.Text}', Terbitan_Buku = '{tb_PublishE.Text}', Judul_Buku = '{tb_TitleE.Text}', Penulis_Buku = '{tb_WriterE.Text}', Harga_Buku = '{tb_PriceE.Text}' " +
                    $"where ID_Buku = '{idBukuKeep}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                updateDgv();

                clearAll();
                bt_searchE.Text = "";

                cb_FilterE.SelectedIndex = 0;

                MessageBox.Show("Edit Success!", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void cb_FilterE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_FilterE.SelectedIndex == 0)
            {
                updateDgv();

                //bt_searchM.Text = "";
            }

            else if (cb_FilterE.SelectedIndex == 1)
            {
                dtAvail = new DataTable();
                sqlQuery = "SELECT ID_buku, ISBN_Buku, Terbitan_Buku, Judul_Buku, Penulis_Buku, Harga_Buku, Qty_Buku, Status_Avail_Buku, Status_Del_Buku from buku WHERE Status_Avail_Buku = 1;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtAvail);
                DGV_Edit.DataSource = dtAvail;

                //bt_searchM.Text = "";
            }

            else if (cb_FilterE.SelectedIndex == 2)
            {
                dtUnavail = new DataTable();
                sqlQuery = "SELECT ID_buku, ISBN_Buku, Terbitan_Buku, Judul_Buku, Penulis_Buku, Harga_Buku, Qty_Buku, Status_Avail_Buku, Status_Del_Buku from buku WHERE Status_Avail_Buku = 0;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtUnavail);
                DGV_Edit.DataSource = dtUnavail;

                //bt_searchE.Text = "";
            }
        }

        private void bt_searchE_Click(object sender, EventArgs e)
        {
            dtSearch = new DataTable();
            sqlQuery = $"SELECT ID_buku, ISBN_Buku, Terbitan_Buku, Judul_Buku, Penulis_Buku, Harga_Buku, Qty_Buku, Status_Avail_Buku, Status_Del_Buku from buku WHERE Judul_Buku like '%{tb_searchE.Text}%' OR Judul_Buku like '{tb_searchE.Text}%' OR Judul_Buku like '%{tb_searchE.Text}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtSearch);
            DGV_Edit.DataSource = dtSearch;

            cb_FilterE.SelectedIndex = 0;
        }

        private void tb_IsbnE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_PublishE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_PriceE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_TitleE_TextChanged(object sender, EventArgs e)
        {
            if (tb_TitleE.Text.Length >= 3 && tb_PublishE.Text.Length == 4)
            {
                bt_Edit.Enabled = true;
            }
            else
            {
                bt_Edit.Enabled = false;
            }
        }

        private void tb_PublishE_TextChanged(object sender, EventArgs e)
        {
            if (tb_TitleE.Text.Length >= 3 && tb_PublishE.Text.Length == 4)
            {
                bt_Edit.Enabled = true;
            }
            else
            {
                bt_Edit.Enabled = false;
            }



        }
    }
}
