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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ALP_Revisi__2_
{
    public partial class F_Staff : Form
    {
        NotaTotalan Nota = new NotaTotalan();
        mdiparents mdiparents;
        ReturnBook ReturnBook;
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dtStaff;
        string sql;

        public F_Staff()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=localhost;uid=root;pwd=@RagcatsL0ve; database= indramar_20232_dbd_6");
            conn.Open();
            conn.Close();

            sql = "select email_staff, id_staff from staff;";
            cmd = new MySqlCommand(sql, conn);
            adapter = new MySqlDataAdapter(cmd);
            dtStaff = new DataTable();
            adapter.Fill(dtStaff);

        }
        string ID_Staff;
        string email;

        private void bt_Login_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text != "" && tb_Password.Text != "")
            {
                bool logged = false;
                for (int i = 0; i < dtStaff.Rows.Count; i++)
                {
                    if ((dtStaff.Rows[i][0].ToString() == tb_Username.Text || dtStaff.Rows[i][0].ToString().Substring(0, dtStaff.Rows[i][0].ToString().IndexOf("@")) == tb_Username.Text) && dtStaff.Rows[i][1].ToString() == tb_Password.Text)
                    {
                        logged = true;
                        email = dtStaff.Rows[i][0].ToString();
                        ID_Staff = tb_Password.Text;
                        email = dtStaff.Rows[i][0].ToString();
                        mdiparents = new mdiparents(ID_Staff, email);
                        mdiparents.Show();
                        this.Hide();
                    }
                }
                if (logged == false)
                {
                    MessageBox.Show("Email or Password is Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Fill In All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
