namespace ALP_Revisi__2_
{
    partial class RegisMember
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
            this.bt_Registration = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_NamaRM = new System.Windows.Forms.TextBox();
            this.tb_NoTelpRM = new System.Windows.Forms.TextBox();
            this.DGV_RegisMember = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_EmailRM = new System.Windows.Forms.TextBox();
            this.bt_KTP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_RegisMember)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Registration
            // 
            this.bt_Registration.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Registration.Location = new System.Drawing.Point(401, 268);
            this.bt_Registration.Name = "bt_Registration";
            this.bt_Registration.Size = new System.Drawing.Size(198, 28);
            this.bt_Registration.TabIndex = 21;
            this.bt_Registration.Text = "Registration";
            this.bt_Registration.UseVisualStyleBackColor = false;
            this.bt_Registration.Click += new System.EventHandler(this.bt_Registration_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nomor Telepon Aktif";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Full Name";
            // 
            // tb_NamaRM
            // 
            this.tb_NamaRM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_NamaRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NamaRM.Location = new System.Drawing.Point(359, 58);
            this.tb_NamaRM.Name = "tb_NamaRM";
            this.tb_NamaRM.Size = new System.Drawing.Size(271, 24);
            this.tb_NamaRM.TabIndex = 18;
            // 
            // tb_NoTelpRM
            // 
            this.tb_NoTelpRM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_NoTelpRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NoTelpRM.Location = new System.Drawing.Point(359, 115);
            this.tb_NoTelpRM.Name = "tb_NoTelpRM";
            this.tb_NoTelpRM.Size = new System.Drawing.Size(271, 24);
            this.tb_NoTelpRM.TabIndex = 17;
            this.tb_NoTelpRM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_NoTelp_KeyPress);
            // 
            // DGV_RegisMember
            // 
            this.DGV_RegisMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_RegisMember.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV_RegisMember.Location = new System.Drawing.Point(37, 34);
            this.DGV_RegisMember.Name = "DGV_RegisMember";
            this.DGV_RegisMember.RowHeadersVisible = false;
            this.DGV_RegisMember.RowHeadersWidth = 82;
            this.DGV_RegisMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_RegisMember.Size = new System.Drawing.Size(276, 280);
            this.DGV_RegisMember.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "KTP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Email Adress";
            // 
            // tb_EmailRM
            // 
            this.tb_EmailRM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_EmailRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EmailRM.Location = new System.Drawing.Point(359, 171);
            this.tb_EmailRM.Name = "tb_EmailRM";
            this.tb_EmailRM.Size = new System.Drawing.Size(271, 24);
            this.tb_EmailRM.TabIndex = 25;
            // 
            // bt_KTP
            // 
            this.bt_KTP.Location = new System.Drawing.Point(359, 219);
            this.bt_KTP.Name = "bt_KTP";
            this.bt_KTP.Size = new System.Drawing.Size(120, 23);
            this.bt_KTP.TabIndex = 28;
            this.bt_KTP.Text = "Upload File";
            this.bt_KTP.UseVisualStyleBackColor = true;
            this.bt_KTP.Click += new System.EventHandler(this.bt_KTP_Click);
            // 
            // RegisMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(693, 410);
            this.Controls.Add(this.bt_KTP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_EmailRM);
            this.Controls.Add(this.bt_Registration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_NamaRM);
            this.Controls.Add(this.tb_NoTelpRM);
            this.Controls.Add(this.DGV_RegisMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisMember";
            this.Text = "Username";
            this.Load += new System.EventHandler(this.RegisMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_RegisMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Registration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_NamaRM;
        private System.Windows.Forms.TextBox tb_NoTelpRM;
        private System.Windows.Forms.DataGridView DGV_RegisMember;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_EmailRM;
        private System.Windows.Forms.Button bt_KTP;
    }
}