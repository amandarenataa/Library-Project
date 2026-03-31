namespace ALP_Revisi__2_
{
    partial class Borrowbook
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
            this.bt_UpdateB = new System.Windows.Forms.Button();
            this.bt_DelB = new System.Windows.Forms.Button();
            this.cb_QuantityB = new System.Windows.Forms.ComboBox();
            this.cb_CustomerID2B = new System.Windows.Forms.ComboBox();
            this.cb_CutomerID1B = new System.Windows.Forms.ComboBox();
            this.cb_BookIDB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_AddB = new System.Windows.Forms.Button();
            this.bt_Done = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Borrow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Borrow)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_UpdateB
            // 
            this.bt_UpdateB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_UpdateB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_UpdateB.Location = new System.Drawing.Point(414, 248);
            this.bt_UpdateB.Name = "bt_UpdateB";
            this.bt_UpdateB.Size = new System.Drawing.Size(224, 34);
            this.bt_UpdateB.TabIndex = 46;
            this.bt_UpdateB.Text = "Update";
            this.bt_UpdateB.UseVisualStyleBackColor = false;
            this.bt_UpdateB.Click += new System.EventHandler(this.bt_UpdateB_Click);
            // 
            // bt_DelB
            // 
            this.bt_DelB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_DelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DelB.Location = new System.Drawing.Point(536, 209);
            this.bt_DelB.Name = "bt_DelB";
            this.bt_DelB.Size = new System.Drawing.Size(102, 34);
            this.bt_DelB.TabIndex = 45;
            this.bt_DelB.Text = "Delete";
            this.bt_DelB.UseVisualStyleBackColor = false;
            this.bt_DelB.Click += new System.EventHandler(this.bt_DelB_Click);
            // 
            // cb_QuantityB
            // 
            this.cb_QuantityB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_QuantityB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_QuantityB.FormattingEnabled = true;
            this.cb_QuantityB.Location = new System.Drawing.Point(392, 175);
            this.cb_QuantityB.Name = "cb_QuantityB";
            this.cb_QuantityB.Size = new System.Drawing.Size(99, 21);
            this.cb_QuantityB.TabIndex = 44;
            // 
            // cb_CustomerID2B
            // 
            this.cb_CustomerID2B.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_CustomerID2B.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_CustomerID2B.FormattingEnabled = true;
            this.cb_CustomerID2B.Location = new System.Drawing.Point(494, 116);
            this.cb_CustomerID2B.Name = "cb_CustomerID2B";
            this.cb_CustomerID2B.Size = new System.Drawing.Size(166, 21);
            this.cb_CustomerID2B.TabIndex = 43;
            // 
            // cb_CutomerID1B
            // 
            this.cb_CutomerID1B.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_CutomerID1B.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_CutomerID1B.FormattingEnabled = true;
            this.cb_CutomerID1B.Location = new System.Drawing.Point(390, 116);
            this.cb_CutomerID1B.Name = "cb_CutomerID1B";
            this.cb_CutomerID1B.Size = new System.Drawing.Size(99, 21);
            this.cb_CutomerID1B.TabIndex = 42;
            this.cb_CutomerID1B.SelectionChangeCommitted += new System.EventHandler(this.cb_CutomerID1B_SelectionChangeCommitted);
            // 
            // cb_BookIDB
            // 
            this.cb_BookIDB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_BookIDB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_BookIDB.FormattingEnabled = true;
            this.cb_BookIDB.Location = new System.Drawing.Point(390, 58);
            this.cb_BookIDB.Name = "cb_BookIDB";
            this.cb_BookIDB.Size = new System.Drawing.Size(270, 21);
            this.cb_BookIDB.TabIndex = 41;
            this.cb_BookIDB.SelectionChangeCommitted += new System.EventHandler(this.cb_BookIDB_SelectionChangeCommitted);
            this.cb_BookIDB.TextChanged += new System.EventHandler(this.cb_BookIDB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Quantity";
            // 
            // bt_AddB
            // 
            this.bt_AddB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_AddB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddB.Location = new System.Drawing.Point(414, 209);
            this.bt_AddB.Name = "bt_AddB";
            this.bt_AddB.Size = new System.Drawing.Size(102, 34);
            this.bt_AddB.TabIndex = 39;
            this.bt_AddB.Text = "Add";
            this.bt_AddB.UseVisualStyleBackColor = false;
            this.bt_AddB.Click += new System.EventHandler(this.bt_AddB_Click);
            // 
            // bt_Done
            // 
            this.bt_Done.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Done.Location = new System.Drawing.Point(414, 288);
            this.bt_Done.Name = "bt_Done";
            this.bt_Done.Size = new System.Drawing.Size(224, 34);
            this.bt_Done.TabIndex = 38;
            this.bt_Done.Text = "Done";
            this.bt_Done.UseVisualStyleBackColor = false;
            this.bt_Done.Click += new System.EventHandler(this.bt_Done_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Book Name";
            // 
            // DGV_Borrow
            // 
            this.DGV_Borrow.AllowUserToAddRows = false;
            this.DGV_Borrow.AllowUserToDeleteRows = false;
            this.DGV_Borrow.AllowUserToResizeColumns = false;
            this.DGV_Borrow.AllowUserToResizeRows = false;
            this.DGV_Borrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Borrow.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV_Borrow.Location = new System.Drawing.Point(12, 27);
            this.DGV_Borrow.Name = "DGV_Borrow";
            this.DGV_Borrow.RowHeadersVisible = false;
            this.DGV_Borrow.RowHeadersWidth = 82;
            this.DGV_Borrow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Borrow.Size = new System.Drawing.Size(368, 280);
            this.DGV_Borrow.TabIndex = 35;
            this.DGV_Borrow.DoubleClick += new System.EventHandler(this.DGV_Borrow_DoubleClick);
            // 
            // Borrowbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(693, 410);
            this.Controls.Add(this.bt_UpdateB);
            this.Controls.Add(this.bt_DelB);
            this.Controls.Add(this.cb_QuantityB);
            this.Controls.Add(this.cb_CustomerID2B);
            this.Controls.Add(this.cb_CutomerID1B);
            this.Controls.Add(this.cb_BookIDB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_AddB);
            this.Controls.Add(this.bt_Done);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_Borrow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Borrowbook";
            this.Text = "Borrowbook";
            this.Load += new System.EventHandler(this.Borrowbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Borrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_UpdateB;
        private System.Windows.Forms.Button bt_DelB;
        private System.Windows.Forms.ComboBox cb_QuantityB;
        private System.Windows.Forms.ComboBox cb_CustomerID2B;
        private System.Windows.Forms.ComboBox cb_CutomerID1B;
        private System.Windows.Forms.ComboBox cb_BookIDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_AddB;
        private System.Windows.Forms.Button bt_Done;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Borrow;
    }
}