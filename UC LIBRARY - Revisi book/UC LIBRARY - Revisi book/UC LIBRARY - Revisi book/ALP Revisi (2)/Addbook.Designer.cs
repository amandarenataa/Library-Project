namespace ALP_Revisi__2_
{
    partial class Addbook
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
            this.cb_FilterA = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_TopicA = new System.Windows.Forms.ComboBox();
            this.bt_Add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_PriceA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_IsbnA = new System.Windows.Forms.TextBox();
            this.tb_PublishA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_TitleA = new System.Windows.Forms.TextBox();
            this.tb_WriterA = new System.Windows.Forms.TextBox();
            this.DGV_Add = new System.Windows.Forms.DataGridView();
            this.bt_searchA = new System.Windows.Forms.Button();
            this.tb_searchA = new System.Windows.Forms.TextBox();
            this.rBt_fictionA = new System.Windows.Forms.RadioButton();
            this.rBt_nonFictionA = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Add)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Filter:";
            // 
            // cb_FilterA
            // 
            this.cb_FilterA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_FilterA.FormattingEnabled = true;
            this.cb_FilterA.Items.AddRange(new object[] {
            "All Books",
            "Available Books",
            "Unavailable Books"});
            this.cb_FilterA.Location = new System.Drawing.Point(301, 28);
            this.cb_FilterA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_FilterA.Name = "cb_FilterA";
            this.cb_FilterA.Size = new System.Drawing.Size(164, 21);
            this.cb_FilterA.TabIndex = 50;
            this.cb_FilterA.SelectedIndexChanged += new System.EventHandler(this.cb_FilterA_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(679, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Topic";
            // 
            // cb_TopicA
            // 
            this.cb_TopicA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_TopicA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_TopicA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TopicA.Items.AddRange(new object[] {
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
            this.cb_TopicA.Location = new System.Drawing.Point(496, 307);
            this.cb_TopicA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_TopicA.Name = "cb_TopicA";
            this.cb_TopicA.Size = new System.Drawing.Size(172, 25);
            this.cb_TopicA.TabIndex = 34;
            this.cb_TopicA.SelectedIndexChanged += new System.EventHandler(this.cb_TopicA_SelectedIndexChanged);
            // 
            // bt_Add
            // 
            this.bt_Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add.Location = new System.Drawing.Point(126, 306);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(224, 34);
            this.bt_Add.TabIndex = 46;
            this.bt_Add.Text = "Add Book";
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Book Price";
            // 
            // tb_PriceA
            // 
            this.tb_PriceA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_PriceA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PriceA.Location = new System.Drawing.Point(497, 254);
            this.tb_PriceA.Name = "tb_PriceA";
            this.tb_PriceA.Size = new System.Drawing.Size(271, 24);
            this.tb_PriceA.TabIndex = 44;
            this.tb_PriceA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_PriceA_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Published Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "ISBN";
            // 
            // tb_IsbnA
            // 
            this.tb_IsbnA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_IsbnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_IsbnA.Location = new System.Drawing.Point(497, 149);
            this.tb_IsbnA.Name = "tb_IsbnA";
            this.tb_IsbnA.Size = new System.Drawing.Size(271, 24);
            this.tb_IsbnA.TabIndex = 41;
            this.tb_IsbnA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_IsbnA_KeyPress);
            // 
            // tb_PublishA
            // 
            this.tb_PublishA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_PublishA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PublishA.Location = new System.Drawing.Point(497, 202);
            this.tb_PublishA.Name = "tb_PublishA";
            this.tb_PublishA.Size = new System.Drawing.Size(271, 24);
            this.tb_PublishA.TabIndex = 40;
            this.tb_PublishA.TextChanged += new System.EventHandler(this.tb_PublishA_TextChanged);
            this.tb_PublishA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_PublishA_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Writer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Book Title";
            // 
            // tb_TitleA
            // 
            this.tb_TitleA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_TitleA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TitleA.Location = new System.Drawing.Point(497, 45);
            this.tb_TitleA.Name = "tb_TitleA";
            this.tb_TitleA.Size = new System.Drawing.Size(271, 24);
            this.tb_TitleA.TabIndex = 37;
            this.tb_TitleA.TextChanged += new System.EventHandler(this.tb_TitleA_TextChanged);
            // 
            // tb_WriterA
            // 
            this.tb_WriterA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_WriterA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_WriterA.Location = new System.Drawing.Point(497, 97);
            this.tb_WriterA.Name = "tb_WriterA";
            this.tb_WriterA.Size = new System.Drawing.Size(271, 24);
            this.tb_WriterA.TabIndex = 36;
            // 
            // DGV_Add
            // 
            this.DGV_Add.AllowUserToAddRows = false;
            this.DGV_Add.AllowUserToDeleteRows = false;
            this.DGV_Add.AllowUserToResizeColumns = false;
            this.DGV_Add.AllowUserToResizeRows = false;
            this.DGV_Add.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Add.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGV_Add.Location = new System.Drawing.Point(31, 54);
            this.DGV_Add.Name = "DGV_Add";
            this.DGV_Add.RowHeadersVisible = false;
            this.DGV_Add.RowHeadersWidth = 51;
            this.DGV_Add.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Add.Size = new System.Drawing.Size(434, 238);
            this.DGV_Add.TabIndex = 35;
            // 
            // bt_searchA
            // 
            this.bt_searchA.BackgroundImage = global::ALP_Revisi__2_.Properties.Resources._61088;
            this.bt_searchA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_searchA.Location = new System.Drawing.Point(221, 24);
            this.bt_searchA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_searchA.Name = "bt_searchA";
            this.bt_searchA.Size = new System.Drawing.Size(24, 24);
            this.bt_searchA.TabIndex = 53;
            this.bt_searchA.UseVisualStyleBackColor = true;
            this.bt_searchA.Click += new System.EventHandler(this.bt_searchA_Click);
            // 
            // tb_searchA
            // 
            this.tb_searchA.Location = new System.Drawing.Point(31, 26);
            this.tb_searchA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_searchA.Name = "tb_searchA";
            this.tb_searchA.Size = new System.Drawing.Size(187, 20);
            this.tb_searchA.TabIndex = 52;
            // 
            // rBt_fictionA
            // 
            this.rBt_fictionA.Location = new System.Drawing.Point(681, 311);
            this.rBt_fictionA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBt_fictionA.Name = "rBt_fictionA";
            this.rBt_fictionA.Size = new System.Drawing.Size(77, 16);
            this.rBt_fictionA.TabIndex = 0;
            this.rBt_fictionA.TabStop = true;
            this.rBt_fictionA.Text = "Fiction";
            this.rBt_fictionA.UseVisualStyleBackColor = true;
            // 
            // rBt_nonFictionA
            // 
            this.rBt_nonFictionA.AutoSize = true;
            this.rBt_nonFictionA.Location = new System.Drawing.Point(681, 329);
            this.rBt_nonFictionA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rBt_nonFictionA.Name = "rBt_nonFictionA";
            this.rBt_nonFictionA.Size = new System.Drawing.Size(76, 17);
            this.rBt_nonFictionA.TabIndex = 54;
            this.rBt_nonFictionA.TabStop = true;
            this.rBt_nonFictionA.Text = "Non-fiction";
            this.rBt_nonFictionA.UseVisualStyleBackColor = true;
            // 
            // Addbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rBt_nonFictionA);
            this.Controls.Add(this.rBt_fictionA);
            this.Controls.Add(this.bt_searchA);
            this.Controls.Add(this.tb_searchA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_FilterA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_TopicA);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_PriceA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_IsbnA);
            this.Controls.Add(this.tb_PublishA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_TitleA);
            this.Controls.Add(this.tb_WriterA);
            this.Controls.Add(this.DGV_Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Addbook";
            this.Text = "Addbook";
            this.Load += new System.EventHandler(this.Addbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Add)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_FilterA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_TopicA;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_PriceA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_IsbnA;
        private System.Windows.Forms.TextBox tb_PublishA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_TitleA;
        private System.Windows.Forms.TextBox tb_WriterA;
        private System.Windows.Forms.DataGridView DGV_Add;
        private System.Windows.Forms.Button bt_searchA;
        private System.Windows.Forms.TextBox tb_searchA;
        private System.Windows.Forms.RadioButton rBt_fictionA;
        private System.Windows.Forms.RadioButton rBt_nonFictionA;
    }
}