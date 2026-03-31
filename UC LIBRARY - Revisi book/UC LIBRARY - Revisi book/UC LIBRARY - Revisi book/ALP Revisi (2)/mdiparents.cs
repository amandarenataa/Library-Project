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
    public partial class mdiparents : Form
    {
        Borrowbook borrowbook;
        ReturnBook returnBook;
        RegisMember regismember;
        Addbook addbook;
        Removebook removebook;
        Editbook editbook;


        string staffID = "";
        string email = "";
        public mdiparents(string _idStaff, string _email)
        {
            InitializeComponent();
            staffID = _idStaff;
            email = _email;
        }

        private void closeChilds()
        {
            foreach(Control c in panel2.Controls)
            {
                if(c is Form)
                    panel2.Controls.Remove(c);
            }
            foreach(Form c in this.MdiChildren)
            {
                c.Close();
            }
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeChilds();
            returnBook = new ReturnBook(staffID);
            returnBook.MdiParent = this;
            this.panel2.Controls.Add(returnBook);
            returnBook.Show();
        }

        private void mdiparents_Load(object sender, EventArgs e)
        {
            menuStrip1.Size = new Size(this.Size.Width, 42);
            borrowbook = new Borrowbook(staffID);
            borrowbook.MdiParent = this;
            this.panel2.Controls.Add(borrowbook);
            borrowbook.Show();
            lb_EmailD.Text = email;
            lb_UsernameD.Text = email.Substring(0, email.IndexOf("@"));
        }

        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeChilds();
            borrowbook = new Borrowbook(staffID);
            borrowbook.MdiParent = this;
            this.panel2.Controls.Add(borrowbook);
            borrowbook.Show();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeChilds();
            regismember = new RegisMember();
            regismember.MdiParent = this;
            this.panel2.Controls.Add(regismember);
            regismember.Show();
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeChilds();
            addbook = new Addbook();
            addbook.MdiParent = this;
            this.panel2.Controls.Add(addbook);
            addbook.Show();
        }

        private void removeBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeChilds();
            removebook = new Removebook();
            removebook.MdiParent = this;
            this.panel2.Controls.Add(removebook);
            removebook.Show();
        }

        private void editBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeChilds();
            editbook = new Editbook();
            editbook.MdiParent = this;
            this.panel2.Controls.Add(editbook);
            editbook.Show();
        }
    }
}
