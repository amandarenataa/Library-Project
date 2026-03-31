namespace ALP_Revisi__2_
{
    partial class Editbook
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
            this.tb_searchE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_FilterE = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_TopicE = new System.Windows.Forms.ComboBox();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_PriceE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_IsbnE = new System.Windows.Forms.TextBox();
            this.tb_PublishE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_TitleE = new System.Windows.Forms.TextBox();
            this.tb_WriterE = new System.Windows.Forms.TextBox();
            this.DGV_Edit = new System.Windows.Forms.DataGridView();
            this.bt_searchE = new System.Windows.Forms.Button();
            this.rBt_nonFictionE = new System.Windows.Forms.RadioButton();
            this.rBt_fictionE = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Edit)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_searchE
            // 
            this.tb_searchE.Location = new System.Drawing.Point(33, 30);
            this.tb_searchE.Name = "tb_searchE";
            this.tb_searchE.Size = new System.Drawing.Size(248, 22);
            this.tb_searchE.TabIndex = 74;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 73;
            this.label8.Text = "Filter:";
            // 
            // cb_FilterE
            // 
            this.cb_FilterE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_FilterE.FormattingEnabled = true;
            this.cb_FilterE.Items.AddRange(new object[] {
            "All Books",
            "Available Books",
            "Unavailable Books"});
            this.cb_FilterE.Location = new System.Drawing.Point(394, 28);
            this.cb_FilterE.Name = "cb_FilterE";
            this.cb_FilterE.Size = new System.Drawing.Size(218, 24);
            this.cb_FilterE.TabIndex = 72;
            this.cb_FilterE.SelectedIndexChanged += new System.EventHandler(this.cb_FilterE_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(901, 352);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 71;
            this.label7.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(653, 352);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 69;
            this.label6.Text = "Topic";
            // 
            // cb_TopicE
            // 
            this.cb_TopicE.Enabled = false;
            this.cb_TopicE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TopicE.Items.AddRange(new object[] {
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
            this.cb_TopicE.Location = new System.Drawing.Point(654, 371);
            this.cb_TopicE.Name = "cb_TopicE";
            this.cb_TopicE.Size = new System.Drawing.Size(228, 30);
            this.cb_TopicE.TabIndex = 56;
            // 
            // bt_Edit
            // 
            this.bt_Edit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Edit.Location = new System.Drawing.Point(160, 369);
            this.bt_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(299, 42);
            this.bt_Edit.TabIndex = 68;
            this.bt_Edit.Text = "Edit Book";
            this.bt_Edit.UseVisualStyleBackColor = false;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(651, 287);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 67;
            this.label5.Text = "Book Price";
            // 
            // tb_PriceE
            // 
            this.tb_PriceE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_PriceE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PriceE.Location = new System.Drawing.Point(655, 306);
            this.tb_PriceE.Margin = new System.Windows.Forms.Padding(4);
            this.tb_PriceE.Name = "tb_PriceE";
            this.tb_PriceE.Size = new System.Drawing.Size(361, 29);
            this.tb_PriceE.TabIndex = 66;
            this.tb_PriceE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_PriceE_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(651, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "Published Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(651, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 64;
            this.label4.Text = "ISBN";
            // 
            // tb_IsbnE
            // 
            this.tb_IsbnE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_IsbnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_IsbnE.Location = new System.Drawing.Point(655, 176);
            this.tb_IsbnE.Margin = new System.Windows.Forms.Padding(4);
            this.tb_IsbnE.Name = "tb_IsbnE";
            this.tb_IsbnE.Size = new System.Drawing.Size(361, 29);
            this.tb_IsbnE.TabIndex = 63;
            this.tb_IsbnE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_IsbnE_KeyPress);
            // 
            // tb_PublishE
            // 
            this.tb_PublishE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_PublishE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PublishE.Location = new System.Drawing.Point(655, 241);
            this.tb_PublishE.Margin = new System.Windows.Forms.Padding(4);
            this.tb_PublishE.Name = "tb_PublishE";
            this.tb_PublishE.Size = new System.Drawing.Size(361, 29);
            this.tb_PublishE.TabIndex = 62;
            this.tb_PublishE.TextChanged += new System.EventHandler(this.tb_PublishE_TextChanged);
            this.tb_PublishE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_PublishE_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(651, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 61;
            this.label2.Text = "Writer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 60;
            this.label1.Text = "Book Title";
            // 
            // tb_TitleE
            // 
            this.tb_TitleE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_TitleE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TitleE.Location = new System.Drawing.Point(655, 48);
            this.tb_TitleE.Margin = new System.Windows.Forms.Padding(4);
            this.tb_TitleE.Name = "tb_TitleE";
            this.tb_TitleE.Size = new System.Drawing.Size(361, 29);
            this.tb_TitleE.TabIndex = 59;
            this.tb_TitleE.TextChanged += new System.EventHandler(this.tb_TitleE_TextChanged);
            // 
            // tb_WriterE
            // 
            this.tb_WriterE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_WriterE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_WriterE.Location = new System.Drawing.Point(655, 112);
            this.tb_WriterE.Margin = new System.Windows.Forms.Padding(4);
            this.tb_WriterE.Name = "tb_WriterE";
            this.tb_WriterE.Size = new System.Drawing.Size(361, 29);
            this.tb_WriterE.TabIndex = 58;
            // 
            // DGV_Edit
            // 
            this.DGV_Edit.AllowUserToAddRows = false;
            this.DGV_Edit.AllowUserToDeleteRows = false;
            this.DGV_Edit.AllowUserToResizeColumns = false;
            this.DGV_Edit.AllowUserToResizeRows = false;
            this.DGV_Edit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Edit.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV_Edit.Location = new System.Drawing.Point(33, 59);
            this.DGV_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_Edit.Name = "DGV_Edit";
            this.DGV_Edit.RowHeadersVisible = false;
            this.DGV_Edit.RowHeadersWidth = 51;
            this.DGV_Edit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Edit.Size = new System.Drawing.Size(579, 293);
            this.DGV_Edit.TabIndex = 57;
            this.DGV_Edit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Edit_CellClick);
            // 
            // bt_searchE
            // 
            this.bt_searchE.BackgroundImage = global::ALP_Revisi__2_.Properties.Resources._61088;
            this.bt_searchE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_searchE.Location = new System.Drawing.Point(287, 27);
            this.bt_searchE.Name = "bt_searchE";
            this.bt_searchE.Size = new System.Drawing.Size(32, 29);
            this.bt_searchE.TabIndex = 75;
            this.bt_searchE.UseVisualStyleBackColor = true;
            this.bt_searchE.Click += new System.EventHandler(this.bt_searchE_Click);
            // 
            // rBt_nonFictionE
            // 
            this.rBt_nonFictionE.AutoSize = true;
            this.rBt_nonFictionE.Enabled = false;
            this.rBt_nonFictionE.Location = new System.Drawing.Point(904, 393);
            this.rBt_nonFictionE.Name = "rBt_nonFictionE";
            this.rBt_nonFictionE.Size = new System.Drawing.Size(91, 20);
            this.rBt_nonFictionE.TabIndex = 77;
            this.rBt_nonFictionE.TabStop = true;
            this.rBt_nonFictionE.Text = "Non-fiction";
            this.rBt_nonFictionE.UseVisualStyleBackColor = true;
            // 
            // rBt_fictionE
            // 
            this.rBt_fictionE.Enabled = false;
            this.rBt_fictionE.Location = new System.Drawing.Point(904, 371);
            this.rBt_fictionE.Name = "rBt_fictionE";
            this.rBt_fictionE.Size = new System.Drawing.Size(91, 20);
            this.rBt_fictionE.TabIndex = 76;
            this.rBt_fictionE.TabStop = true;
            this.rBt_fictionE.Text = "Fiction";
            this.rBt_fictionE.UseVisualStyleBackColor = true;
            // 
            // Editbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 507);
            this.Controls.Add(this.rBt_nonFictionE);
            this.Controls.Add(this.rBt_fictionE);
            this.Controls.Add(this.bt_searchE);
            this.Controls.Add(this.tb_searchE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_FilterE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_TopicE);
            this.Controls.Add(this.bt_Edit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_PriceE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_IsbnE);
            this.Controls.Add(this.tb_PublishE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_TitleE);
            this.Controls.Add(this.tb_WriterE);
            this.Controls.Add(this.DGV_Edit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Editbook";
            this.Text = "Editbook";
            this.Load += new System.EventHandler(this.Editbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Edit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_searchE;
        private System.Windows.Forms.TextBox tb_searchE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_FilterE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_TopicE;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_PriceE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_IsbnE;
        private System.Windows.Forms.TextBox tb_PublishE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_TitleE;
        private System.Windows.Forms.TextBox tb_WriterE;
        private System.Windows.Forms.DataGridView DGV_Edit;
        private System.Windows.Forms.RadioButton rBt_nonFictionE;
        private System.Windows.Forms.RadioButton rBt_fictionE;
    }
}