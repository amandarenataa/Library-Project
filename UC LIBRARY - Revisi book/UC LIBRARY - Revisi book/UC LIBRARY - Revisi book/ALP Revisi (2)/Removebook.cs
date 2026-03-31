using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

using MySql.Data.MySqlClient;

namespace ALP_Revisi__2_
{
    public partial class Removebook : Form
    {
        /* yang diubah
         * semua tb jadi read only, cb jadi enabled = false (di property)
         * selebihnya sama kyk addbook
         */

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;

        DataTable dtRemoveBook;
        DataTable dtAvail;
        DataTable dtUnavail;

        DataTable dtSearch;

        DataGridViewRow selectedRow;

        public Removebook()
        {
            InitializeComponent();
        }

        private void Removebook_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=@RagcatsL0ve;database=indramar_20232_dbd_6");

            updateDgv();

            cb_FilterM.SelectedIndex = 0;
        }

        private void DGV_Remove_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                selectedRow = DGV_Remove.Rows[e.RowIndex];

                tb_TitleM.Text = selectedRow.Cells["Judul_Buku"].Value.ToString();
                tb_WriterM.Text = selectedRow.Cells["Penulis_Buku"].Value.ToString();
                tb_isbnM.Text = selectedRow.Cells["ISBN_Buku"].Value.ToString();
                tb_PublishM.Text = selectedRow.Cells["Terbitan_Buku"].Value.ToString();
                tb_PriceM.Text = selectedRow.Cells["Harga_Buku"].Value.ToString();

                string idBuku = selectedRow.Cells["ID_Buku"].Value.ToString();
                int index_cbTopic = Convert.ToInt32(idBuku.Substring(1, 3)) - 1;
                cb_TopicM.SelectedIndex = index_cbTopic;

                string cbCategoryType = idBuku.Substring(0, 1);
                if (cbCategoryType == "A")
                {
                    rBt_fictionM.Checked = true;
                    rBt_nonFictionM.Checked = false;
                }
                else if (cbCategoryType == "B")
                {
                    rBt_fictionM.Checked = false;
                    rBt_nonFictionM.Checked = true;
                }


            }
        }

        private void updateDgv()
        {
            dtRemoveBook = new DataTable();
            sqlQuery = "SELECT ID_buku, ISBN_Buku, Terbitan_Buku, Judul_Buku, Penulis_Buku, Harga_Buku, Qty_Buku, Status_Avail_Buku, Status_Del_Buku from buku;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtRemoveBook);
            DGV_Remove.DataSource = dtRemoveBook;
        }

        private void clearAll()
        {
            tb_TitleM.Text = "";
            tb_WriterM.Text = "";
            tb_isbnM.Text = "";
            tb_PublishM.Text = "";
            tb_PriceM.Text = "";
            cb_TopicM.SelectedIndex = -1;
            rBt_fictionM.Checked = false;
            rBt_nonFictionM.Checked = false;
        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            if (tb_TitleM.Text == "")
            {
                MessageBox.Show("Please Select Book to Remove!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //sqlQuery = $"DELETE FROM buku " +
                //           $"where ID_Buku = '{selectedRow.Cells["ID_Buku"].Value.ToString()}' AND Judul_Buku = '{tb_TitleM.Text}' AND ISBN_Buku = '{tb_isbnM.Text}' AND Penulis_Buku = '{tb_WriterM.Text}' AND Terbitan_Buku = '{tb_PublishM.Text}';";
                sqlQuery = $"UPDATE buku SET Status_Del_Buku = 1, Status_Avail_Buku = 0 " +
                           $"where ID_Buku = '{selectedRow.Cells["ID_Buku"].Value.ToString()}' AND Judul_Buku = '{tb_TitleM.Text}' AND ISBN_Buku = '{tb_isbnM.Text}' AND Penulis_Buku = '{tb_WriterM.Text}' AND Terbitan_Buku = '{tb_PublishM.Text}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                MessageBox.Show($"Successfully Removed Book: {tb_TitleM.Text}", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                int qtyBook = qtyBookCounter(tb_TitleM.Text, dtRemoveBook) - 1;

                sqlQuery = $"UPDATE buku SET Qty_Buku = {qtyBook} WHERE Judul_Buku = '{tb_TitleM.Text}';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlConnect.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                updateDgv();

                clearAll();

                cb_FilterM.SelectedIndex = 0;

            }


        }

        // generate QTY buku
        private static int qtyBookCounter(string title, DataTable dtAddFake)
        {
            int newQty = 0;

            foreach (DataRow dr in dtAddFake.Rows)
            {
                if (title.ToLower() == dr["Judul_Buku"].ToString().ToLower())
                {
                    newQty++;
                }
            }

            return newQty;
        }


        private void cb_FilterM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_FilterM.SelectedIndex == 0)
            {
                updateDgv();
            }

            else if (cb_FilterM.SelectedIndex == 1)
            {
                dtAvail = new DataTable();
                sqlQuery = "SELECT ID_buku, ISBN_Buku, Terbitan_Buku, Judul_Buku, Penulis_Buku, Harga_Buku, Qty_Buku, Status_Avail_Buku, Status_Del_Buku from buku WHERE Status_Avail_Buku = 1;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtAvail);
                DGV_Remove.DataSource = dtAvail;
            }

            else if (cb_FilterM.SelectedIndex == 2)
            {
                dtUnavail = new DataTable();
                sqlQuery = "SELECT ID_buku, ISBN_Buku, Terbitan_Buku, Judul_Buku, Penulis_Buku, Harga_Buku, Qty_Buku, Status_Avail_Buku, Status_Del_Buku from buku WHERE Status_Avail_Buku = 0;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtUnavail);
                DGV_Remove.DataSource = dtUnavail;
            }
        }

        private void bt_searchM_Click(object sender, EventArgs e)
        {
            dtSearch = new DataTable();
            sqlQuery = $"SELECT ID_buku, ISBN_Buku, Terbitan_Buku, Judul_Buku, Penulis_Buku, Harga_Buku, Qty_Buku, Status_Avail_Buku, Status_Del_Buku from buku WHERE Judul_Buku like '%{tb_searchM.Text}%' OR Judul_Buku like '{tb_searchM.Text}%' OR Judul_Buku like '%{tb_searchM.Text}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtSearch);
            DGV_Remove.DataSource = dtSearch;

            cb_FilterM.SelectedIndex = 0;
        }
    }
}
