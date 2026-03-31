using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALP_Revisi__2_
{
    public partial class RegisMember : Form
    {
        public RegisMember()
        {
            InitializeComponent();
        }
        MySqlConnection SqlConnect;
        MySqlCommand SqlCommand;
        MySqlDataAdapter SqlDataAdapter;
        string query;
        OpenFileDialog ofd = new OpenFileDialog();
        string KTPath;
        bool choose = false;
        DataTable dtMember = new DataTable();
        DataTable dtDGVMember = new DataTable();
        private void RegisMember_Load(object sender, EventArgs e)
        {
            SqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=@RagcatsL0ve;database=indramar_20232_dbd_6");
            SqlConnect.Open();
            query = "SELECT * FROM peminjam;";
            SqlCommand = new MySqlCommand(query, SqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(dtMember);
            query = "SELECT id_peminjam as `ID Peminjam`, nama_peminjam as `Nama Peminjam`, IF(jenis_peminjam = '1', 'Non-UC', IF(jenis_peminjam = '2', 'UC (Dosen/Staff)', 'UC (Mahasiswa)')) as `Jenis Peminjam` FROM peminjam;";
            SqlCommand = new MySqlCommand(query, SqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(SqlCommand);
            SqlDataAdapter.Fill(dtDGVMember);
            DGV_RegisMember.DataSource = dtDGVMember;
            tb_NoTelpRM.MaxLength = 13;
            SqlConnect.Close();
        }
        private void bt_KTP_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Image Files(*.jpg, *.jpeg, *.bmp, *.png)|*.jpg;*.jpeg;*.bmp;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                choose = true;
                KTPath = ofd.FileName;
            }
        }

        private void bt_Registration_Click(object sender, EventArgs e)
        {
            string[] hasil;
            string inisial;
            string id = "";
            if (tb_NamaRM.Text != "" && tb_NoTelpRM.Text != "" && tb_EmailRM.Text != "" && choose == true)
            {
                if (tb_EmailRM.Text.Contains("@"))
                {
                    hasil = tb_EmailRM.Text.Split('@');
                    if (hasil[1].Length > 0)
                    {
                        bool exist = false;
                        for (int i = 0; i < dtMember.Rows.Count; i++)
                        {
                            if (dtMember.Rows[i][2].ToString().ToLower() == tb_NamaRM.Text.ToLower() && dtMember.Rows[i][4].ToString().ToLower() == tb_EmailRM.Text.ToLower())
                            {
                                exist = true;
                                MessageBox.Show("Member Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        if (exist == false)
                        {
                            hasil = tb_NamaRM.Text.Split(' ');
                            if (hasil.Length > 1)
                            {
                                inisial = hasil[0].Substring(0, 1).ToUpper() + hasil[1].Substring(0, 1).ToUpper();
                            }
                            else
                            {
                                inisial = hasil[0].Substring(0, 2).ToUpper();
                            }
                            int count = 1;
                            for (int i = 0; i < dtMember.Rows.Count; i++)
                            {
                                if (dtMember.Rows[i][0].ToString().Substring(0, 2) == inisial)
                                {
                                    count++;
                                }
                            }
                            if (count > 99)
                            {
                                id = inisial + count.ToString();
                            }
                            else if (count > 9)
                            {
                                id = inisial + "0" + count.ToString();
                            }
                            else
                            {
                                id = inisial + "00" + count.ToString();
                            }
                        }
                        dtMember.Rows.Add(id, id, tb_NamaRM.Text, "1", tb_EmailRM.Text, "FALSE", tb_NoTelpRM.Text);
                        dtDGVMember.Rows.Add(id, tb_NamaRM.Text, "Non-UC");
                        query = $"INSERT INTO peminjam (ID_Peminjam, ID_Regis ,Nama_Peminjam,Jenis_Peminjam,Email_Peminjam,Status_Del_Peminjam,NoTelp_Peminjam) VALUES ('{id}', '{id}', '{tb_NamaRM.Text}','1', '{tb_EmailRM.Text}', FALSE, '{tb_NoTelpRM.Text}');";
                        SqlCommand = new MySqlCommand(query, SqlConnect);
                        SqlConnect.Open();
                        SqlCommand.ExecuteNonQuery();
                        query = $"INSERT INTO regis_member (ID_Peminjam, ID_Regis ,Nama_Regis,Tgl_Regis,Biaya_Regis,Foto_KTP,Status_Del_Regis) VALUES ('{id}', '{id}', '{tb_NamaRM.Text}','{DateTime.Now.ToString("yyyy-MM-dd")}', '300000', '{KTPath}', 0);";
                        SqlCommand = new MySqlCommand(query, SqlConnect);
                        SqlCommand.ExecuteNonQuery();
                        SqlConnect.Close();
                        tb_NamaRM.Clear();
                        tb_EmailRM.Clear();
                        tb_NoTelpRM.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Email Format Not Valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Email Format Not Valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Fill In All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tb_NoTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
