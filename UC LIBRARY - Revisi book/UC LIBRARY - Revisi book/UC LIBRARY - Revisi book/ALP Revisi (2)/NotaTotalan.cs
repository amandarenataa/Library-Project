using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALP_Revisi__2_
{
    public partial class NotaTotalan : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        string sql;
        DataTable dtDenda = new DataTable();
        ReturnBook Return;
        DataTable dtdataperrow;
        

        public NotaTotalan(DataTable dt, string _staffId, Form form)
        {
            InitializeComponent();
            dtDenda = dt;
            id_staff = _staffId;
            Return = (ReturnBook)form;
        }

        public NotaTotalan()
        {
            InitializeComponent();
        }

        string id_staff;

        private void NotaTotalan_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=localhost;uid=root;pwd=@RagcatsL0ve; database= indramar_20232_dbd_6");
            conn.Open();
            conn.Close();


            lb_custID.Text = dtDenda.Rows[0][1].ToString();
            lb_transID.Text = dtDenda.Rows[0][0].ToString();
            lb_custNAMEG.Text = dtDenda.Rows[0][7].ToString();
            DGV_denda.DataSource = dtDenda;
            PerhitunganDenda();

           

        }
        int DendaYgHrsDibayar = 0;
        int apatelat = 0;
        int aparusak = 0;
        string rusak;
        int hilang = 0;
        bool inputdenda = false;
        int dendaPerRow = 0;
        public void PerhitunganDenda()
        {
            dtdataperrow = new DataTable();
            dtdataperrow.Columns.Add("Denda");
            foreach (DataRow dr in dtDenda.Rows)
            {
                dendaPerRow = 0;
                int telat = Convert.ToInt32(dr[2]);
                if (telat > 0)
                {
                    inputdenda = true;
                    apatelat = 1;
                    int denda = telat * 5000;
                    DendaYgHrsDibayar += denda;
                    dendaPerRow += denda;
                }
                if (dr[3].ToString() == "Berat")
                {
                    inputdenda = true;
                    aparusak = 1;
                    rusak = "B";
                    DendaYgHrsDibayar += Convert.ToInt32(dr[5]);
                   dendaPerRow += Convert.ToInt32(dr[5]);
                }
                else if (dr[3].ToString() == "Ringan")
                {
                    inputdenda = true;
                    aparusak = 1;
                    rusak = "R";
                }
                if (dr[4].ToString() == "True")
                {
                    inputdenda = true;
                    hilang = 1;
                    DendaYgHrsDibayar += Convert.ToInt32(dr[5]);
                    dendaPerRow += Convert.ToInt32(dr[5]);
                }
                dtdataperrow.Rows.Add(dendaPerRow);
            }
            lb_hargaBayar.Text = DendaYgHrsDibayar.ToString("N0");
        }
        bool Reset;
        int row = 0;
        private void bt_Remove_Click(object sender, EventArgs e)
        {
            if (inputdenda == true)
            {
                foreach (DataRow dr in dtDenda.Rows)
                {
                    if (aparusak == 0)
                    {
                        if (apatelat == 0)
                        {
                            sql = $"insert into denda(ID_Nota, ID_Buku, Is_Telat, Telat_Ket, Is_Rusak, Rusak_Ket, Is_Hilang, Nominal_Denda, Status_Pembayaran, ID_Staff, Status_Del_Denda) values ('{dr[0]}','{dr[6]}',{apatelat}, null, {aparusak}, null, {hilang}, '{dtdataperrow.Rows[row][0]}', 1, '{id_staff}', 0 )";
                            conn.Open();
                            cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        else
                        {
                            sql = $"insert into denda(ID_Nota, ID_Buku, Is_Telat, Telat_Ket, Is_Rusak, Rusak_Ket, Is_Hilang, Nominal_Denda, Status_Pembayaran, ID_Staff, Status_Del_Denda) values ('{dr[0]}','{dr[6]}',{apatelat}, '{dr[2]}', {aparusak}, null, {hilang}, '{dtdataperrow.Rows[row][0]}', 1, '{id_staff}', 0 )";
                            conn.Open();
                            cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                    else if (apatelat == 0 && aparusak == 1)
                    {
                        sql = $"insert into denda(ID_Nota, ID_Buku, Is_Telat, Telat_Ket, Is_Rusak, Rusak_Ket, Is_Hilang, Nominal_Denda, Status_Pembayaran, ID_Staff, Status_Del_Denda) values ('{dr[0]}','{dr[6]}',{apatelat}, null, {aparusak}, '{rusak}', {hilang}, '{dtdataperrow.Rows[row][0]}', 1, '{id_staff}', 0 )";
                        conn.Open();
                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    else
                    {
                        sql = $"insert into denda(ID_Nota, ID_Buku, Is_Telat, Telat_Ket, Is_Rusak, Rusak_Ket, Is_Hilang, Nominal_Denda, Status_Pembayaran, ID_Staff, Status_Del_Denda) values ('{dr[0]}','{dr[6]}',{apatelat}, '{dr[2]}', {aparusak}, '{rusak}', {hilang}, '{dtdataperrow.Rows[row][0]}', 1, '{id_staff}', 0 )";
                        conn.Open();
                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    row++;
                }
            }
            Reset = true;
            Return.RESET(Reset);
            this.Close();
        }
    }
}
