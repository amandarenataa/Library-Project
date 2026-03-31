namespace ALP_Revisi__2_
{
    partial class ReturnBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bt_input = new System.Windows.Forms.Button();
            this.dgv_berhasil = new System.Windows.Forms.DataGridView();
            this.tb_telat = new System.Windows.Forms.TextBox();
            this.pn_Return = new System.Windows.Forms.Panel();
            this.rb_Berat = new System.Windows.Forms.RadioButton();
            this.rb_Ringan = new System.Windows.Forms.RadioButton();
            this.ch_Rusak = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ch_Hilang = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Nota = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_BookidR = new System.Windows.Forms.TextBox();
            this.tb_CustomeridR = new System.Windows.Forms.TextBox();
            this.DGV_Return = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_berhasil)).BeginInit();
            this.pn_Return.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Return)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Book ID";
            // 
            // bt_input
            // 
            this.bt_input.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_input.Location = new System.Drawing.Point(470, 311);
            this.bt_input.Name = "bt_input";
            this.bt_input.Size = new System.Drawing.Size(132, 34);
            this.bt_input.TabIndex = 46;
            this.bt_input.Text = "Input";
            this.bt_input.UseVisualStyleBackColor = false;
            this.bt_input.Click += new System.EventHandler(this.bt_input_Click);
            // 
            // dgv_berhasil
            // 
            this.dgv_berhasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_berhasil.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_berhasil.Location = new System.Drawing.Point(23, 210);
            this.dgv_berhasil.Name = "dgv_berhasil";
            this.dgv_berhasil.RowHeadersVisible = false;
            this.dgv_berhasil.RowHeadersWidth = 82;
            this.dgv_berhasil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_berhasil.Size = new System.Drawing.Size(419, 128);
            this.dgv_berhasil.TabIndex = 45;
            // 
            // tb_telat
            // 
            this.tb_telat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_telat.Enabled = false;
            this.tb_telat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_telat.Location = new System.Drawing.Point(471, 183);
            this.tb_telat.Name = "tb_telat";
            this.tb_telat.Size = new System.Drawing.Size(64, 24);
            this.tb_telat.TabIndex = 44;
            this.tb_telat.Visible = false;
            // 
            // pn_Return
            // 
            this.pn_Return.Controls.Add(this.rb_Berat);
            this.pn_Return.Controls.Add(this.rb_Ringan);
            this.pn_Return.Location = new System.Drawing.Point(535, 240);
            this.pn_Return.Name = "pn_Return";
            this.pn_Return.Size = new System.Drawing.Size(138, 65);
            this.pn_Return.TabIndex = 43;
            this.pn_Return.Visible = false;
            // 
            // rb_Berat
            // 
            this.rb_Berat.AutoSize = true;
            this.rb_Berat.Location = new System.Drawing.Point(24, 37);
            this.rb_Berat.Name = "rb_Berat";
            this.rb_Berat.Size = new System.Drawing.Size(50, 17);
            this.rb_Berat.TabIndex = 1;
            this.rb_Berat.TabStop = true;
            this.rb_Berat.Text = "Berat";
            this.rb_Berat.UseVisualStyleBackColor = true;
            // 
            // rb_Ringan
            // 
            this.rb_Ringan.AutoSize = true;
            this.rb_Ringan.Location = new System.Drawing.Point(24, 14);
            this.rb_Ringan.Name = "rb_Ringan";
            this.rb_Ringan.Size = new System.Drawing.Size(59, 17);
            this.rb_Ringan.TabIndex = 0;
            this.rb_Ringan.TabStop = true;
            this.rb_Ringan.Text = "Ringan";
            this.rb_Ringan.UseVisualStyleBackColor = true;
            // 
            // ch_Rusak
            // 
            this.ch_Rusak.AutoSize = true;
            this.ch_Rusak.Location = new System.Drawing.Point(514, 240);
            this.ch_Rusak.Name = "ch_Rusak";
            this.ch_Rusak.Size = new System.Drawing.Size(15, 14);
            this.ch_Rusak.TabIndex = 42;
            this.ch_Rusak.UseVisualStyleBackColor = true;
            this.ch_Rusak.CheckedChanged += new System.EventHandler(this.ch_Rusak_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(671, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Hilang";
            // 
            // ch_Hilang
            // 
            this.ch_Hilang.AutoSize = true;
            this.ch_Hilang.Location = new System.Drawing.Point(717, 167);
            this.ch_Hilang.Name = "ch_Hilang";
            this.ch_Hilang.Size = new System.Drawing.Size(15, 14);
            this.ch_Hilang.TabIndex = 40;
            this.ch_Hilang.UseVisualStyleBackColor = true;
            this.ch_Hilang.CheckedChanged += new System.EventHandler(this.ch_Hilang_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Rusak";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Telat";
            // 
            // bt_Nota
            // 
            this.bt_Nota.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Nota.Location = new System.Drawing.Point(642, 311);
            this.bt_Nota.Name = "bt_Nota";
            this.bt_Nota.Size = new System.Drawing.Size(132, 34);
            this.bt_Nota.TabIndex = 37;
            this.bt_Nota.Text = "Nota";
            this.bt_Nota.UseVisualStyleBackColor = false;
            this.bt_Nota.Visible = false;
            this.bt_Nota.Click += new System.EventHandler(this.bt_Nota_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Customer ID";
            // 
            // tb_BookidR
            // 
            this.tb_BookidR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_BookidR.Enabled = false;
            this.tb_BookidR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_BookidR.Location = new System.Drawing.Point(471, 70);
            this.tb_BookidR.Name = "tb_BookidR";
            this.tb_BookidR.Size = new System.Drawing.Size(271, 24);
            this.tb_BookidR.TabIndex = 35;
            // 
            // tb_CustomeridR
            // 
            this.tb_CustomeridR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_CustomeridR.Enabled = false;
            this.tb_CustomeridR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CustomeridR.Location = new System.Drawing.Point(470, 129);
            this.tb_CustomeridR.Name = "tb_CustomeridR";
            this.tb_CustomeridR.Size = new System.Drawing.Size(271, 24);
            this.tb_CustomeridR.TabIndex = 34;
            // 
            // DGV_Return
            // 
            this.DGV_Return.AllowUserToAddRows = false;
            this.DGV_Return.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Return.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV_Return.Location = new System.Drawing.Point(23, 70);
            this.DGV_Return.Name = "DGV_Return";
            this.DGV_Return.RowHeadersVisible = false;
            this.DGV_Return.RowHeadersWidth = 82;
            this.DGV_Return.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Return.Size = new System.Drawing.Size(419, 128);
            this.DGV_Return.TabIndex = 33;
            this.DGV_Return.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Return_CellContentClick);
            this.DGV_Return.DoubleClick += new System.EventHandler(this.DGV_Return_DoubleClick);
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(813, 385);
            this.Controls.Add(this.bt_input);
            this.Controls.Add(this.dgv_berhasil);
            this.Controls.Add(this.tb_telat);
            this.Controls.Add(this.pn_Return);
            this.Controls.Add(this.ch_Rusak);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ch_Hilang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_Nota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_BookidR);
            this.Controls.Add(this.tb_CustomeridR);
            this.Controls.Add(this.DGV_Return);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnBook";
            this.Text = "ReturnBook";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_berhasil)).EndInit();
            this.pn_Return.ResumeLayout(false);
            this.pn_Return.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Return)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_input;
        private System.Windows.Forms.DataGridView dgv_berhasil;
        private System.Windows.Forms.TextBox tb_telat;
        private System.Windows.Forms.Panel pn_Return;
        private System.Windows.Forms.RadioButton rb_Berat;
        private System.Windows.Forms.RadioButton rb_Ringan;
        private System.Windows.Forms.CheckBox ch_Rusak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ch_Hilang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Nota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_BookidR;
        private System.Windows.Forms.TextBox tb_CustomeridR;
        private System.Windows.Forms.DataGridView DGV_Return;
    }
}