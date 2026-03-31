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
    public partial class Borrowbook : Form
    {
        string ID_STAFF;
        public Borrowbook(string id_staff)
        {
            InitializeComponent();
            ID_STAFF = id_staff;
        }
        MySqlConnection SqlConnection;
        MySqlCommand SqlCommand;
        MySqlDataAdapter SqlDataAdapter;
        string query;
        DataTable dtBook = new DataTable();
        DataTable dtBorrowDis = new DataTable();
        DataTable dtBorrowVal = new DataTable();
        DataTable dtAvail = new DataTable();
        List<string> type = new List<string> { "Non-UC", "UC (Dosen-Staff)", "UC (Mahasiswa)" };
        string date = DateTime.Now.ToString("ddMMyyyy");
        int qtyavail;
        string iddoubleclick = "";
        private void Borrowbook_Load(object sender, EventArgs e)
        {
            cb_CutomerID1B.DataSource = type;
            SqlConnection = new MySqlConnection("server=localhost;uid=root;pwd=@RagcatsL0ve;database=indramar_20232_dbd_6");
            SqlConnection.Open();
            query = "SELECT id_buku, judul_buku, qty_buku FROM buku WHERE status_avail_buku = '1' AND status_del_buku = '0';";
            SqlCommand = new MySqlCommand(query, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            dtBook.Clear();
            SqlDataAdapter.Fill(dtBook);
            SqlConnection.Close();
            cb_BookIDB.DataSource = dtBook;
            cb_BookIDB.DisplayMember = "judul_buku";
            cb_BookIDB.ValueMember = "id_buku";
            dtBorrowDis.Columns.Add("ID Buku");
            dtBorrowDis.Columns.Add("Judul Buku");
            dtBorrowDis.Columns.Add("ID Peminjam");
            dtBorrowDis.Columns.Add("Quantity");
            DGV_Borrow.DataSource = dtBorrowDis;
            dtBorrowVal.Columns.Add("ID Buku");
            dtBorrowVal.Columns.Add("ID Peminjam");
            dtAvail.Columns.Add("ID Buku");
            dtAvail.Columns.Add("Qty");
            cb_BookIDB.Text = "";
            cb_CutomerID1B.Text = "";
        }

        private void cb_BookIDB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cb_QuantityB.Items.Clear();
            DataTable dtTransaksi = new DataTable();
            qtyavail = 0;
            if (cb_BookIDB.Text != null)
            {
                query = $"SELECT id_buku FROM detail_transaksi WHERE id_buku = '{cb_BookIDB.SelectedValue}' AND keterangan_kembali is NULL AND status_del_detail = 0;";
                SqlCommand = new MySqlCommand(query, SqlConnection);
                SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
                SqlDataAdapter.Fill(dtTransaksi);
                if (dtTransaksi.Rows.Count > 0)
                {
                    qtyavail = Convert.ToInt32(dtBook.Rows[cb_BookIDB.SelectedIndex][2]) - dtTransaksi.Rows.Count;
                }
                else
                {
                    qtyavail = Convert.ToInt32(dtBook.Rows[cb_BookIDB.SelectedIndex][2]);
                }
                for (int i = 1; i <= qtyavail; i++)
                {
                    cb_QuantityB.Items.Add(i);
                }
            }
        }

        private void cb_CutomerID1B_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable peminjam = new DataTable();
            query = $"SELECT id_peminjam FROM peminjam WHERE status_del_peminjam = FALSE AND jenis_peminjam = '{cb_CutomerID1B.SelectedIndex + 1}';";
            SqlConnection.Open();
            SqlCommand = new MySqlCommand(query, SqlConnection);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(peminjam);
            SqlConnection.Close();
            cb_CustomerID2B.DataSource = peminjam;
            cb_CustomerID2B.DisplayMember = "id_peminjam";
        }

        private void bt_AddB_Click(object sender, EventArgs e)
        {
            if (cb_BookIDB.Text != "" && cb_CutomerID1B.Text != "" && cb_CustomerID2B.Text != "" && cb_QuantityB.Text != "" && cb_BookIDB.Text != "")
            {
                if (cb_BookIDB.SelectedValue != null)
                {
                    dtBorrowDis.Rows.Add(cb_BookIDB.SelectedValue, cb_BookIDB.Text, cb_CustomerID2B.Text, cb_QuantityB.Text);
                    dtAvail.Rows.Add(cb_BookIDB.SelectedValue, qtyavail);
                    for (int i = 1; i <= Convert.ToInt32(cb_QuantityB.Text); i++)
                    {
                        dtBorrowVal.Rows.Add(cb_BookIDB.SelectedValue.ToString(), cb_CustomerID2B.Text);
                    }
                    cb_CutomerID1B.Enabled = false;
                    cb_CustomerID2B.Enabled = false;
                    int count = 0;
                    int temp = 0;
                    foreach (DataRow i in dtBook.Rows)
                    {
                        if (i[0].ToString() == cb_BookIDB.SelectedValue.ToString())
                        {
                            count = temp;
                        }
                        temp++;
                    }
                    dtBook.Rows.RemoveAt(count);
                    cb_BookIDB.Text = "";
                    cb_QuantityB.Text = "";
                }
                else
                {
                    MessageBox.Show("Book Already Added In Table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Fill In All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Done_Click(object sender, EventArgs e)
        {
            if (dtBorrowDis.Rows.Count > 0)
            {
                DataTable dtTransaksi = new DataTable();
                query = $"SELECT id_nota FROM transaksi WHERE id_nota LIKE '{date}%';";
                SqlConnection.Open();
                SqlCommand = new MySqlCommand(query, SqlConnection);
                SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
                SqlDataAdapter.Fill(dtTransaksi);
                SqlConnection.Close();
                string idnota = "";
                if (dtTransaksi.Rows.Count < 9)
                {
                    idnota = $"{date}00{dtTransaksi.Rows.Count + 1}";
                }
                else if (dtTransaksi.Rows.Count < 99)
                {
                    idnota = $"{date}0{dtTransaksi.Rows.Count + 1}";
                }
                else
                {
                    idnota = $"{date}{dtTransaksi.Rows.Count + 1}";
                }
                query = $"INSERT INTO transaksi VALUES ('{idnota}', '{ID_STAFF}', '{dtBorrowVal.Rows[0][1]}', '{dtBorrowVal.Rows.Count}', '{DateTime.Now.ToString("yyyy-MM-dd")}', 0);";
                SqlConnection.Open();
                SqlCommand = new MySqlCommand(query, SqlConnection);
                SqlCommand.ExecuteNonQuery();
                SqlConnection.Close();
                foreach (DataRow i in dtBorrowVal.Rows)
                {
                    query = $"INSERT INTO detail_transaksi VALUES ('{idnota}', '{i[0]}', '{DateTime.Now.ToString("yyyy-MM-dd")}', '{DateTime.Now.AddDays(7).ToString("yyyy-MM-dd")}', NULL, NULL, 0)";
                    SqlConnection.Open();
                    SqlCommand = new MySqlCommand(query, SqlConnection);
                    SqlCommand.ExecuteNonQuery();
                    SqlConnection.Close();
                }
                for (int i = 0; i < dtAvail.Rows.Count; i++)
                {
                    if (Convert.ToInt16(dtAvail.Rows[i][1]) - Convert.ToInt16(dtBorrowDis.Rows[i][3]) == 0)
                    {
                        query = $"UPDATE buku SET status_avail_buku = 0 WHERE id_buku = '{dtAvail.Rows[i][0]}';";
                        SqlConnection.Open();
                        SqlCommand = new MySqlCommand(query, SqlConnection);
                        SqlCommand.ExecuteNonQuery();
                        SqlConnection.Close();
                    }
                }
                dtBorrowDis.Clear();
                dtBorrowVal.Clear();
                dtAvail.Clear();
                dtTransaksi.Clear();
                cb_QuantityB.Items.Clear();
                cb_BookIDB.Enabled = true;
                cb_CutomerID1B.Enabled = true;
                cb_CustomerID2B.Enabled = true;
                bt_AddB.Enabled = true;
                query = "SELECT id_buku, judul_buku, qty_buku FROM buku WHERE status_avail_buku = '1' AND status_del_buku = '0';";
                SqlCommand = new MySqlCommand(query, SqlConnection);
                SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
                dtBook.Clear();
                SqlDataAdapter.Fill(dtBook);
                cb_BookIDB.Text = "";
                cb_CutomerID1B.Text = "";
                cb_CustomerID2B.Text = "";
                cb_QuantityB.Text = "";
            }
            else
            {
                MessageBox.Show("Please Input Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bt_DelB_Click(object sender, EventArgs e)
        {
            if (dtBorrowDis.Rows.Count > 0)
            {
                if (cb_BookIDB.Text != "" && cb_QuantityB.Text != "" && iddoubleclick != "")
                {
                    int temp = 0;
                    int ind = 0;
                    foreach (DataRow a in dtBorrowDis.Rows)
                    {
                        if (a[0].ToString() == iddoubleclick)
                        {
                            ind = temp;
                        }
                        temp++;
                    }
                    dtAvail.Rows.RemoveAt(ind);
                    dtBorrowDis.Rows.RemoveAt(ind);
                    temp = 0;
                    List<int> ind1 = new List<int>();
                    int min = 0;
                    foreach (DataRow i in dtBorrowVal.Rows)
                    {
                        if (i[0].ToString() == iddoubleclick)
                        {
                            ind1.Add(temp);
                        }
                        temp++;
                    }
                    foreach (int i in ind1)
                    {
                        dtBorrowVal.Rows.RemoveAt(i - min);
                        min++;
                    }
                    DataTable dtBuku = new DataTable();
                    DataTable dtTransaksi = new DataTable();
                    query = $"SELECT id_buku, judul_buku, qty_buku from buku where id_buku = '{iddoubleclick}';";
                    SqlCommand = new MySqlCommand(query, SqlConnection);
                    SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
                    SqlDataAdapter.Fill(dtBuku);
                    dtBook.Rows.Add(dtBuku.Rows[0][0].ToString(), dtBuku.Rows[0][1].ToString(), dtBuku.Rows[0][2].ToString());
                    cb_BookIDB.Text = "";
                    cb_QuantityB.Text = "";
                    cb_QuantityB.Items.Clear();
                    cb_BookIDB.Enabled = true;
                    bt_AddB.Enabled = true;
                    iddoubleclick = "";
                    ind1.Clear();
                }
                else
                {
                    MessageBox.Show("Please Select An Item From Table First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Data Yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bt_UpdateB_Click(object sender, EventArgs e)
        {
            if (dtBorrowDis.Rows.Count > 0)
            {
                if (cb_BookIDB.Text != "" && cb_QuantityB.Text != "" && iddoubleclick != "")
                {
                    int temp = 0;
                    List<int> ind1 = new List<int>();
                    int min = 0;
                    foreach (DataRow i in dtBorrowVal.Rows)
                    {
                        if (i[0].ToString() == iddoubleclick)
                        {
                            ind1.Add(temp);
                        }
                        temp++;
                    }
                    foreach (int i in ind1)
                    {
                        dtBorrowVal.Rows.RemoveAt(i - min);
                        min++;
                    }
                    dtBorrowDis.Rows[DGV_Borrow.CurrentCell.RowIndex][3] = cb_QuantityB.Text;
                    for (int i = 1; i <= Convert.ToInt32(cb_QuantityB.Text); i++)
                    {
                        dtBorrowVal.Rows.Add(iddoubleclick, cb_CustomerID2B.Text);
                    }
                    cb_BookIDB.Text = "";
                    cb_QuantityB.Text = "";
                    cb_QuantityB.Items.Clear();
                    cb_BookIDB.Enabled = true;
                    bt_AddB.Enabled = true;
                    iddoubleclick = "";
                    ind1.Clear();
                }
                else
                {
                    MessageBox.Show("Please Select An Item From Table First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You Have No Data Yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGV_Borrow_DoubleClick(object sender, EventArgs e)
        {
            int index = DGV_Borrow.CurrentCell.RowIndex;
            cb_BookIDB.Text = dtBorrowDis.Rows[index][1].ToString();
            cb_CustomerID2B.Text = dtBorrowDis.Rows[index][2].ToString();
            iddoubleclick = dtBorrowDis.Rows[index][0].ToString();
            cb_QuantityB.Items.Clear();
            for (int i = 1; i <= Convert.ToInt32(dtAvail.Rows[index][1]); i++)
            {
                cb_QuantityB.Items.Add(i);
            }
            cb_QuantityB.Text = dtBorrowDis.Rows[index][3].ToString();
            cb_BookIDB.Enabled = false;
            bt_AddB.Enabled = false;
        }

        private void cb_BookIDB_TextChanged(object sender, EventArgs e)
        {
            //if(cb_BookIDB.Text != "")
            //{
            //    string cbText = cb_BookIDB.Text;
            //    DataTable dt = new DataTable();
            //    dt.Columns.Add("id_buku");
            //    dt.Columns.Add("judul_buku");
            //    dt.Columns.Add("qty_buku");
            //    for (int i = 0; i < dtBook.Rows.Count; i++)
            //    {
            //        if (dtBook.Rows[i][1].ToString().Contains(cbText))
            //        {
            //            dt.Rows.Add(dtBook.Rows[i].ToString());
            //        }
            //    }
            //    foreach(DataRow a in dt.Rows)
            //    {
            //        MessageBox.Show(a[1].ToString());
            //    }
            //    cb_BookIDB.DataSource = dt;
            //    cb_BookIDB.DisplayMember = "judul_buku";
            //    cb_BookIDB.ValueMember = "id_buku";
            
        }
    }
}
