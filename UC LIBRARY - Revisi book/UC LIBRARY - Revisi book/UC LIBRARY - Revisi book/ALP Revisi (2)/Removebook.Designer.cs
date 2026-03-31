namespace ALP_Revisi__2_
{
    partial class Removebook
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
            this.label8 = new System.Windows.Forms.Label();
            this.cb_FilterM = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_TopicM = new System.Windows.Forms.ComboBox();
            this.bt_Remove = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_PriceM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_isbnM = new System.Windows.Forms.TextBox();
            this.tb_PublishM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_TitleM = new System.Windows.Forms.TextBox();
            this.tb_WriterM = new System.Windows.Forms.TextBox();
            this.DGV_Remove = new System.Windows.Forms.DataGridView();
            this.bt_searchM = new System.Windows.Forms.Button();
            this.tb_searchM = new System.Windows.Forms.TextBox();
            this.rBt_nonFictionM = new System.Windows.Forms.RadioButton();
            this.rBt_fictionM = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Remove)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(357, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 64;
            this.label8.Text = "Filter:";
            // 
            // cb_FilterM
            // 
            this.cb_FilterM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_FilterM.FormattingEnabled = true;
            this.cb_FilterM.Items.AddRange(new object[] {
            "All Books",
            "Available Books",
            "Unavailable Books"});
            this.cb_FilterM.Location = new System.Drawing.Point(402, 33);
            this.cb_FilterM.Name = "cb_FilterM";
            this.cb_FilterM.Size = new System.Drawing.Size(218, 24);
            this.cb_FilterM.TabIndex = 63;
            this.cb_FilterM.SelectedIndexChanged += new System.EventHandler(this.cb_FilterM_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(912, 357);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 62;
            this.label7.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(661, 357);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 60;
            this.label6.Text = "Topic";
            // 
            // cb_TopicM
            // 
            this.cb_TopicM.Enabled = false;
            this.cb_TopicM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TopicM.Items.AddRange(new object[] {
            "Dental Medicine Collection",
            "Medical Collection",
            "Entrepreneurship Innovation Creativity",
            "Programs, Software",
            "Bibliography",
            "Library, Journalism",
            "Philosophy, Graphology, Psychology, Typology",
            "Knowledge, Research ",
            "Systems",
            "Computer Science, Peripherals",
            "Programming, Programs",
            "Child Psychology, Counseling",
            "Ethics",
            "Religion",
            "Christianity, Jesus, Prayers, Worship",
            "Christian Life, Sermons",
            "Church, Ecclesiology",
            "Catholic, Islam, Buddhism, Hinduism",
            "Sociology, Anthropology",
            "Communication",
            "Social Processes, Culture",
            "Marriage and Family",
            "Politics, Labor",
            "Banks, Cooperatives, Taxes, Credit, Investment, Stocks, Renting",
            "Business Enterprise",
            "Macroeconomics, Microeconomics",
            "Public Administration",
            "Military, Social Problems",
            "Education",
            "Adult Education, Higher Education",
            "Commerce, Transportation",
            "Language, Grammar",
            "Sciences, Mathematics ",
            "Technology",
            "Medicine and Health",
            "Human Physiology",
            "Personal Health, Diseases",
            "Mental Disorders, Surgery, Dentistry, Otology, Ophthalmology, Audiology",
            "Gynecology, Obstetrics, Pediatrics, Geriatrics",
            "Engineering, Electronics",
            "Agriculture, Horticulture",
            "Hunting, Fishing",
            "Food and Drink, Beverages, Cooking",
            "Cooking Techniques",
            "Table Service",
            "Cookbooks",
            "Sewing, Clothing",
            "Child Rearing",
            "Accounting",
            "Bookkeeping time",
            "Financial Reports",
            "Management",
            "Small Enterprises, Big Enterprises",
            "Corporations",
            "Financial Management",
            "Human Resource Management",
            "Employee",
            "Executive Management, Strategic Management, Decision Making, Information Manageme" +
                "nt, Conflict Management, Negotiation",
            "Communication",
            "Informational Programs",
            "Product Control, Packaging, Waste Control",
            "Management of Supplies, Storage Marketing, Sales Management, Consumer Behavior",
            "Advertising, Public Relations",
            "Chemical Engineering, Beverage, Technology, Food Technology",
            "Ceramic, Glass, Pottery, Metallurgy",
            "Textiles",
            "Manufacturing, Furnishing",
            "Furniture",
            "Printing, Bookbinding, photocopying",
            "Clothing, Dressmaking",
            "Construction",
            "Building Materials",
            "Heating, Ventilating",
            "Arts, Decorative Arts, City Planning",
            "Landscape Design",
            "Architecture, Public Structures",
            "Hotels, Motels, Cabins",
            "Decoration of Structures, Interior Architecture",
            "Sculpture; Carving; Numismatics, Ceramic Arts, Art Metalwork",
            "Graphic Arts",
            "Drawing, Comic, Cartoons, Graphic Design, Illustration",
            "Decorative Arts, Folk Art, Antiques",
            "Handicrafts, Calligraphy, Illumination ",
            "Textile Arts, Knitting, Embroidery, Patchwork, Quilting, Batik",
            "Interior Decoration",
            "Furniture and Accessories",
            "Painting and Paintings",
            "Photography, Videography",
            "Music; Public Performances",
            "Games, Indoor and Outdoor Games",
            "Literature and Rhetoric, Poetry, Drama, Fiction, Essays, Speeches, Letters, Humor" +
                ", Satire",
            "History",
            "World History",
            "Geography and Travel Topical Geography, Historical Geography",
            "Biography, Genealogy, Insignia"});
            this.cb_TopicM.Location = new System.Drawing.Point(661, 376);
            this.cb_TopicM.Name = "cb_TopicM";
            this.cb_TopicM.Size = new System.Drawing.Size(228, 30);
            this.cb_TopicM.TabIndex = 59;
            // 
            // bt_Remove
            // 
            this.bt_Remove.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Remove.Location = new System.Drawing.Point(169, 375);
            this.bt_Remove.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(299, 42);
            this.bt_Remove.TabIndex = 58;
            this.bt_Remove.Text = "Remove Book";
            this.bt_Remove.UseVisualStyleBackColor = false;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(659, 293);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 57;
            this.label5.Text = "Book Price";
            // 
            // tb_PriceM
            // 
            this.tb_PriceM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_PriceM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PriceM.Location = new System.Drawing.Point(663, 312);
            this.tb_PriceM.Margin = new System.Windows.Forms.Padding(4);
            this.tb_PriceM.Name = "tb_PriceM";
            this.tb_PriceM.ReadOnly = true;
            this.tb_PriceM.Size = new System.Drawing.Size(361, 29);
            this.tb_PriceM.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(659, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Published Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(659, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "ISBN";
            // 
            // tb_isbnM
            // 
            this.tb_isbnM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_isbnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_isbnM.Location = new System.Drawing.Point(663, 182);
            this.tb_isbnM.Margin = new System.Windows.Forms.Padding(4);
            this.tb_isbnM.Name = "tb_isbnM";
            this.tb_isbnM.ReadOnly = true;
            this.tb_isbnM.Size = new System.Drawing.Size(361, 29);
            this.tb_isbnM.TabIndex = 53;
            // 
            // tb_PublishM
            // 
            this.tb_PublishM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_PublishM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PublishM.Location = new System.Drawing.Point(663, 247);
            this.tb_PublishM.Margin = new System.Windows.Forms.Padding(4);
            this.tb_PublishM.Name = "tb_PublishM";
            this.tb_PublishM.ReadOnly = true;
            this.tb_PublishM.Size = new System.Drawing.Size(361, 29);
            this.tb_PublishM.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(659, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Writer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(659, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Book Title";
            // 
            // tb_TitleM
            // 
            this.tb_TitleM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_TitleM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TitleM.Location = new System.Drawing.Point(663, 54);
            this.tb_TitleM.Margin = new System.Windows.Forms.Padding(4);
            this.tb_TitleM.Name = "tb_TitleM";
            this.tb_TitleM.ReadOnly = true;
            this.tb_TitleM.Size = new System.Drawing.Size(361, 29);
            this.tb_TitleM.TabIndex = 49;
            // 
            // tb_WriterM
            // 
            this.tb_WriterM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_WriterM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_WriterM.Location = new System.Drawing.Point(663, 118);
            this.tb_WriterM.Margin = new System.Windows.Forms.Padding(4);
            this.tb_WriterM.Name = "tb_WriterM";
            this.tb_WriterM.ReadOnly = true;
            this.tb_WriterM.Size = new System.Drawing.Size(361, 29);
            this.tb_WriterM.TabIndex = 48;
            // 
            // DGV_Remove
            // 
            this.DGV_Remove.AllowUserToAddRows = false;
            this.DGV_Remove.AllowUserToDeleteRows = false;
            this.DGV_Remove.AllowUserToResizeColumns = false;
            this.DGV_Remove.AllowUserToResizeRows = false;
            this.DGV_Remove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Remove.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV_Remove.Location = new System.Drawing.Point(41, 65);
            this.DGV_Remove.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_Remove.Name = "DGV_Remove";
            this.DGV_Remove.RowHeadersVisible = false;
            this.DGV_Remove.RowHeadersWidth = 51;
            this.DGV_Remove.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Remove.Size = new System.Drawing.Size(579, 293);
            this.DGV_Remove.TabIndex = 47;
            this.DGV_Remove.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Remove_CellClick);
            // 
            // bt_searchM
            // 
            this.bt_searchM.BackgroundImage = global::ALP_Revisi__2_.Properties.Resources._61088;
            this.bt_searchM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_searchM.Location = new System.Drawing.Point(295, 32);
            this.bt_searchM.Name = "bt_searchM";
            this.bt_searchM.Size = new System.Drawing.Size(32, 29);
            this.bt_searchM.TabIndex = 66;
            this.bt_searchM.UseVisualStyleBackColor = true;
            this.bt_searchM.Click += new System.EventHandler(this.bt_searchM_Click);
            // 
            // tb_searchM
            // 
            this.tb_searchM.Location = new System.Drawing.Point(41, 35);
            this.tb_searchM.Name = "tb_searchM";
            this.tb_searchM.Size = new System.Drawing.Size(248, 22);
            this.tb_searchM.TabIndex = 65;
            // 
            // rBt_nonFictionM
            // 
            this.rBt_nonFictionM.AutoSize = true;
            this.rBt_nonFictionM.Enabled = false;
            this.rBt_nonFictionM.Location = new System.Drawing.Point(913, 402);
            this.rBt_nonFictionM.Name = "rBt_nonFictionM";
            this.rBt_nonFictionM.Size = new System.Drawing.Size(91, 20);
            this.rBt_nonFictionM.TabIndex = 68;
            this.rBt_nonFictionM.TabStop = true;
            this.rBt_nonFictionM.Text = "Non-fiction";
            this.rBt_nonFictionM.UseVisualStyleBackColor = true;
            // 
            // rBt_fictionM
            // 
            this.rBt_fictionM.Enabled = false;
            this.rBt_fictionM.Location = new System.Drawing.Point(913, 380);
            this.rBt_fictionM.Name = "rBt_fictionM";
            this.rBt_fictionM.Size = new System.Drawing.Size(91, 20);
            this.rBt_fictionM.TabIndex = 67;
            this.rBt_fictionM.TabStop = true;
            this.rBt_fictionM.Text = "Fiction";
            this.rBt_fictionM.UseVisualStyleBackColor = true;
            // 
            // Removebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.rBt_nonFictionM);
            this.Controls.Add(this.rBt_fictionM);
            this.Controls.Add(this.bt_searchM);
            this.Controls.Add(this.tb_searchM);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_FilterM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_TopicM);
            this.Controls.Add(this.bt_Remove);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_PriceM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_isbnM);
            this.Controls.Add(this.tb_PublishM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_TitleM);
            this.Controls.Add(this.tb_WriterM);
            this.Controls.Add(this.DGV_Remove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Removebook";
            this.Text = "Remove Book";
            this.Load += new System.EventHandler(this.Removebook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Remove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_FilterM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_TopicM;
        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_PriceM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_isbnM;
        private System.Windows.Forms.TextBox tb_PublishM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_TitleM;
        private System.Windows.Forms.TextBox tb_WriterM;
        private System.Windows.Forms.DataGridView DGV_Remove;
        private System.Windows.Forms.Button bt_searchM;
        private System.Windows.Forms.TextBox tb_searchM;
        private System.Windows.Forms.RadioButton rBt_nonFictionM;
        private System.Windows.Forms.RadioButton rBt_fictionM;
    }
}