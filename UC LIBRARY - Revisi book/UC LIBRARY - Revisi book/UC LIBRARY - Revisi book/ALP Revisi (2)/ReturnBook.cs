using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace ALP_Revisi__2_
{
    public partial class ReturnBook : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dtBelumKembali;
        DataTable dtSudahKembali;
        string sql;
        string ID_STAFF;

        NotaTotalan Nota;

        DataTable dtDenda;
        public ReturnBook(string iD_STAFF)
        {
            InitializeComponent();
            ID_STAFF = iD_STAFF;
        }
        private void ReturnBook_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=localhost;uid=root;pwd=@RagcatsL0ve; database= indramar_20232_dbd_6");
            conn.Open();
            conn.Close();

            IsiDGVSebelum();
            IsiDGVSesudah();

            dtDenda = new DataTable();
            dtDenda.Columns.Add("ID_Nota");
            dtDenda.Columns.Add("ID_Cust");
            dtDenda.Columns.Add("Telat");
            dtDenda.Columns.Add("Rusak");
            dtDenda.Columns.Add("Hilang");
            dtDenda.Columns.Add("Harga");
            dtDenda.Columns.Add("ID_Buku");
            dtDenda.Columns.Add("Nama_Peminjam");

        }

        public void IsiDGVSebelum()
        {
            sql = "select d.id_nota as 'ID Nota', d.tgl_pinjam as 'TGL Pinjam', d.tgl_kembali_exp as 'TGL Kembali EXP',  t.ID_Peminjam as 'ID Peminjam', d.ID_Buku as 'ID Buku', b.harga_buku as 'Harga Buku', p.Nama_Peminjam as 'Nama Peminjam' from detail_transaksi d  left join  transaksi t on t.ID_Nota = d.ID_Nota left join buku b on b.ID_Buku = d.ID_Buku left join peminjam p on p.id_peminjam = t.id_peminjam where Tgl_Kembali_Real is null and t.ID_Nota = d.ID_Nota ;";
            cmd = new MySqlCommand(sql, conn);
            adapter = new MySqlDataAdapter(cmd);
            dtBelumKembali = new DataTable();
            adapter.Fill(dtBelumKembali);

            DGV_Return.DataSource = dtBelumKembali;
        }

        public void IsiDGVSesudah()
        {
            sql = "select d.id_nota, d.tgl_pinjam, d.tgl_kembali_exp, t.ID_Peminjam, d.ID_Buku from detail_transaksi d , " +
                "transaksi t where Tgl_Kembali_Real is not null and t.ID_Nota = d.ID_Nota;";
            cmd = new MySqlCommand(sql, conn);
            adapter = new MySqlDataAdapter(cmd);
            dtSudahKembali = new DataTable();
            adapter.Fill(dtSudahKembali);

            dgv_berhasil.DataSource = dtSudahKembali;
        }
        bool RusakGa = false;
        bool Hilang = false;
        private void ch_Rusak_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Rusak.Checked == true)
            {
                pn_Return.Visible = true;
                RusakGa = true;
                ch_Hilang.Checked = false;
            }
            else
            {
                pn_Return.Visible = false;
                RusakGa = false;
            }
        }
        
        private void ch_Hilang_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Hilang.Checked == true)
            {
                Hilang = true;
                ch_Rusak.Checked = false;
            }
            else
            {
                Hilang = false;
            }
        }
        int terpilih;
        string ID_Nota;
        string ID_Buku;
        string Harga;
        int sdhPilih;
        string custID;
        private void DGV_Return_DoubleClick(object sender, EventArgs e)
        {
            sdhPilih++;
            terpilih = DGV_Return.CurrentRow.Index;

            ID_Nota = dtBelumKembali.Rows[terpilih][0].ToString();
            tb_BookidR.Text = dtBelumKembali.Rows[terpilih][4].ToString();
            custID = dtBelumKembali.Rows[terpilih][6].ToString();

            if (sdhPilih == 1)
            {
                CustID = dtBelumKembali.Rows[terpilih][3].ToString();
            }

            tb_CustomeridR.Text = dtBelumKembali.Rows[terpilih][3].ToString();
            ID_Buku = dtBelumKembali.Rows[terpilih][4].ToString();

            Harga = dtBelumKembali.Rows[terpilih][5].ToString();
            DateTime dateKembali = DateTime.Now.Date;

            string d = dtBelumKembali.Rows[terpilih][2].ToString();
            DateTime dt = DateTime.ParseExact(d, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            int date = dt.Day;
            int month = dt.Month;
            int year = dt.Year;
            DateTime dateReturnEXP = new DateTime(year, month, date);

            TimeSpan difference = dateKembali - dateReturnEXP;

            HariTelat = Convert.ToInt32(difference.TotalDays.ToString());


            tb_telat.Visible = true;
            tb_telat.Text = difference.TotalDays.ToString();


        }
        int HariTelat;
        string Keterangan;
        string rusak;
        string CustID;
        private void bt_input_Click(object sender, EventArgs e)
        {
            if (CustID != tb_CustomeridR.Text)
            {
                MessageBox.Show("Customer ID nya harus sama untuk melakukan inputan tambahan");
                tb_CustomeridR.Clear();
                tb_BookidR.Clear();
                tb_telat.Clear();
            }
            else
            {
                if (HariTelat > 0)
                {
                    if (ch_Hilang.Checked == false)
                    {
                        if (ch_Rusak.Checked == false)
                        {
                            rusak = "Tidak";
                            Keterangan = $"Telat {HariTelat} Hari, Tidak ada Kerusakan";
                        }
                        else
                        {
                            if (rb_Berat.Checked == true)
                            {
                                rusak = "Berat";
                                Keterangan = $"Telat {HariTelat} Hari, Rusak Berat";
                            }
                            else if (rb_Ringan.Checked == true)
                            {
                                rusak = "Ringan";
                                Keterangan = $"Telat {HariTelat} Hari, Rusak Ringan";
                            }
                        }
                    }
                    else
                    {
                        Keterangan = $"Telat {HariTelat} Hari, Hilang";
                    }
                }
                else
                {
                    if (ch_Hilang.Checked == true)
                    {
                        Keterangan = "Hilang";
                    }
                    else
                    {
                        if (ch_Rusak.Checked == false)
                        {
                            rusak = "Tidak";
                            Keterangan = $"Aman, Tidak ada Kerusakan";
                        }
                        else
                        {
                            if (rb_Berat.Checked == true)
                            {
                                rusak = "Berat";
                                Keterangan = $"Rusak Berat";
                            }
                            else if (rb_Ringan.Checked == true)
                            {
                                rusak = "Ringan";
                                Keterangan = $"Rusak Ringan";
                            }
                        }
                    }
                }

                DateTime dt = DateTime.Now;
                string date = dt.ToString();


                sql = $"update detail_transaksi set tgl_kembali_real = '{date.Substring(6, 4) + '-' + date.Substring(0, 2) + '-' + date.Substring(3, 2)}', " +
                    $"keterangan_kembali = '{Keterangan}'  where id_nota = '{ID_Nota}'";
                conn.Open();
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                sql = $"update buku set status_avail_buku = 0 where id_buku = '{ID_Buku}'";
                conn.Open();
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();



                dtDenda.Rows.Add(ID_Nota, CustID, HariTelat, rusak, Hilang, Harga, ID_Buku,custID);


                IsiDGVSebelum();
                IsiDGVSesudah();

                bt_Nota.Visible = true;

                ch_Hilang.Checked = false;
                ch_Rusak.Checked = false;
                tb_BookidR.Clear();
                tb_CustomeridR.Clear();
                tb_telat.Clear();
            }
        }

        private void bt_Nota_Click(object sender, EventArgs e)
        {
            Nota = new NotaTotalan(dtDenda, ID_STAFF,this);
            Nota.Show();
        }

        public void RESET(bool hapus)
        {
            if (hapus == true)
            {
                dtDenda.Clear();
                terpilih = 0;
                ID_Nota = "";
                ID_Buku = "";
                Harga = "";
                sdhPilih = 0;
                RusakGa = false;
                Hilang = false;
                HariTelat = 0;
                Keterangan = "";
                CustID = "";
                bt_Nota.Visible = false;
                ch_Hilang.Checked = false;
                ch_Rusak.Checked = false;
                rb_Berat.Checked = false;
                rb_Ringan.Checked = false;
            }
        }

        private void DGV_Return_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
