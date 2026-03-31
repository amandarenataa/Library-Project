using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ALP_Revisi__2_
{

    /* Catatan perubahan
     * Memperlebar dgv
     * dgv properties > rowheadervisible > false
     * dgv property allowuserto... semuanya false, selection mode = fullrowselect, editmode = editprogramaticaaly
     * 
     * button add digeser krn ada nambah cb baru (topic & category) sklian label buat penjelasannya
     * collection cb_topicA ditambah manual (minta aku copas an nya)
     * collection cb_categoryA -||-
     * 
     * nambah cb_FilterA + collectionnya
     * label filter
     */

    public partial class Addbook : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string sqlQuery;

        DataTable dtAddBook;
        DataTable dtAvail;
        DataTable dtUnavail;

        DataTable dtSearch;

        int indexCategory;
        int index_cbTopic;



        public Addbook()
        {
            InitializeComponent();
        }


        private void Addbook_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=@RagcatsL0ve;database=indramar_20232_dbd_6");

            updateDgv();

            tb_TitleA.MaxLength = 150;
            tb_WriterA.MaxLength = 30;
            tb_IsbnA.MaxLength = 13;
            tb_PublishA.MaxLength = 4;
            tb_PriceA.MaxLength = 9;

            bt_Add.Enabled = false;

            cb_FilterA.SelectedIndex = 0;

        }


        private void bt_Add_Click(object sender, EventArgs e)
        {
            if (tb_TitleA.Text == "" || tb_WriterA.Text == "" || tb_IsbnA.Text == "" || tb_PublishA.Text == "" || tb_PriceA.Text == "" || cb_TopicA.SelectedIndex == -1 || (rBt_fictionA.Checked == false && rBt_nonFictionA.Checked == false))
            {
                MessageBox.Show("All Information Must Be Filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // nyimpan category
                if (rBt_fictionA.Checked == true)
                {
                    indexCategory = 0;
                }
                else if (rBt_nonFictionA.Checked == true)
                {
                    indexCategory = 1;
                }

                // nyimpan id buku
                string resultGenerateIDBook = generateIDBook(indexCategory, index_cbTopic, tb_TitleA.Text, tb_WriterA.Text, dtAddBook);

                // nyimpan qty
                int qtyBook = qtyBookCounter(tb_TitleA.Text, dtAddBook);

                if (qtyBook == 1)
                {
                    sqlQuery = $"insert into buku (ID_Buku, ISBN_Buku, Terbitan_Buku, Judul_Buku, Penulis_Buku, Harga_Buku, Qty_Buku, Status_Avail_Buku, Status_Del_Buku) " +
                           $"values ('{resultGenerateIDBook}', '{tb_IsbnA.Text}', '{tb_PublishA.Text}', '{tb_TitleA.Text}', '{tb_WriterA.Text}', {tb_PriceA.Text}, 1, 1, 0);";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlConnect.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                }
                else if (qtyBook > 1)
                {
                    sqlQuery = $"insert into buku (ID_Buku, ISBN_Buku, Terbitan_Buku, Judul_Buku, Penulis_Buku, Harga_Buku, Qty_Buku, Status_Avail_Buku, Status_Del_Buku) " +
                           $"values ('{resultGenerateIDBook}', '{tb_IsbnA.Text}', '{tb_PublishA.Text}', '{tb_TitleA.Text}', '{tb_WriterA.Text}', {tb_PriceA.Text}, {qtyBook}, 1, 0);";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlConnect.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                    sqlQuery = $"UPDATE buku SET Qty_Buku = {qtyBook} WHERE Judul_Buku = '{tb_TitleA.Text}';";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlConnect.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                }

                updateDgv();

                clearAll();

                cb_FilterA.SelectedIndex = 0;
            }

        }


        // update or show main dgv add
        private void updateDgv()
        {
            dtAddBook = new DataTable();
            sqlQuery = "SELECT ID_buku, ISBN_Buku, Terbitan_Buku, Judul_Buku, Penulis_Buku, Harga_Buku, Qty_Buku, Status_Avail_Buku, Status_Del_Buku from buku;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtAddBook);
            DGV_Add.DataSource = dtAddBook;
        }


        // generate id buku
        private static string generateIDBook(int indexCategory, int indexTopic, string title, string author, DataTable dtAddFake)
        {
            string format1;
            if (indexCategory == 0)
            {
                format1 = "A";
            }
            else
            {
                format1 = "B";
            }

            string format2;
            if (indexTopic < 9)
            {
                format2 = "00" + (indexTopic + 1).ToString();
            }
            else if (indexTopic < 99)
            {
                format2 = "0" + (indexTopic + 1).ToString();
            }
            else
            {
                format2 = (indexTopic + 1).ToString();
            }

            string format3 = title.Substring(0, 3).ToUpper();

            string format4 = author.Substring(0, 1).ToUpper();

            string format5;
            int counterSama = 1;
            string uncompIdBook = format1 + format2 + format3 + format4;
            foreach (DataRow dr in dtAddFake.Rows)
            {
                string columnValue = dr[0].ToString();
                string idBukuSetengah = columnValue.Substring(0, 8);

                if (idBukuSetengah == uncompIdBook)
                {
                    counterSama++;
                }
            }

            if (counterSama < 10)
            {
                format5 = "0" + counterSama.ToString();
            }
            else
            {
                format5 = counterSama.ToString();
            }


            string idBook = format1 + format2 + format3 + format4 + format5;
            return idBook;
        }


        private void cb_TopicA_SelectedIndexChanged(object sender, EventArgs e)
        {
            index_cbTopic = cb_TopicA.SelectedIndex;
        }


        private void clearAll()
        {
            tb_TitleA.Text = "";
            tb_WriterA.Text = "";
            tb_IsbnA.Text = "";
            tb_PublishA.Text = "";
            tb_PriceA.Text = "";
            cb_TopicA.SelectedIndex = -1;
            rBt_fictionA.Checked = false;
            rBt_nonFictionA.Checked = false;
        }


        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearAll();

            Removebook formRemoveBook = new Removebook();
            formRemoveBook.ShowDialog();
        }


        // generate QTY buku
        private static int qtyBookCounter(string title, DataTable dtAddFake)
        {
            int newQty = 1;

            foreach (DataRow dr in dtAddFake.Rows)
            {
                if (title.ToLower() == dr["Judul_Buku"].ToString().ToLower())
                {
                    newQty++;
                }
            }

            return newQty;
        }

        private void tb_IsbnA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_PublishA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_PriceA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_PublishA_TextChanged(object sender, EventArgs e)
        {
            if (tb_PublishA.Text.Length == 4 && tb_TitleA.Text.Length >= 3)
            {
                bt_Add.Enabled = true;
            }
            else
            {
                bt_Add.Enabled = false;
            }

        }

        private void tb_TitleA_TextChanged(object sender, EventArgs e)
        {
            if (tb_TitleA.Text.Length >= 3 && tb_PublishA.Text.Length == 4)
            {
                bt_Add.Enabled = true;
            }
            else
            {
                bt_Add.Enabled = false;
            }
        }

        private void cb_FilterA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_FilterA.SelectedIndex == 0)
            {
                updateDgv();
            }

            else if (cb_FilterA.SelectedIndex == 1)
            {
                dtAvail = new DataTable();
                sqlQuery = "SELECT ID_buku, ISBN_Buku, Terbitan_Buku, Judul_Buku, Penulis_Buku, Harga_Buku, Qty_Buku, Status_Avail_Buku, Status_Del_Buku from buku WHERE Status_Avail_Buku = 1;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtAvail);
                DGV_Add.DataSource = dtAvail;
            }

            else if (cb_FilterA.SelectedIndex == 2)
            {
                dtUnavail = new DataTable();
                sqlQuery = "SELECT ID_buku, ISBN_Buku, Terbitan_Buku, Judul_Buku, Penulis_Buku, Harga_Buku, Qty_Buku, Status_Avail_Buku, Status_Del_Buku from buku WHERE Status_Avail_Buku = 0;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtUnavail);
                DGV_Add.DataSource = dtUnavail;
            }
        }

        private void bt_searchA_Click(object sender, EventArgs e)
        {
            dtSearch = new DataTable();
            sqlQuery = $"SELECT ID_buku, ISBN_Buku, Terbitan_Buku, Judul_Buku, Penulis_Buku, Harga_Buku, Qty_Buku, Status_Avail_Buku, Status_Del_Buku from buku WHERE Judul_Buku like '%{tb_searchA.Text}%' OR Judul_Buku like '{tb_searchA.Text}%' OR Judul_Buku like '%{tb_searchA.Text}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtSearch);
            DGV_Add.DataSource = dtSearch;

            cb_FilterA.SelectedIndex = 0;
        }
    }
}
