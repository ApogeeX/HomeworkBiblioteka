namespace HomeworkBiblioteka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.returnCopyButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.borrowCopyButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSelectedBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refresh = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.copiesTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.authorComboBox = new System.Windows.Forms.ComboBox();
            this.addBookButton = new System.Windows.Forms.Button();
            this.shortDescBox = new System.Windows.Forms.TextBox();
            this.bookTitleBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.authorsDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addAuthorButton = new System.Windows.Forms.Button();
            this.addAuthorBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.genresDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addGenreButton = new System.Windows.Forms.Button();
            this.addGenreBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genresDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 414);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.returnCopyButton);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.borrowCopyButton);
            this.tabPage1.Controls.Add(this.searchBox);
            this.tabPage1.Controls.Add(this.searchButton);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.refresh);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Library";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // returnCopyButton
            // 
            this.returnCopyButton.Location = new System.Drawing.Point(199, 357);
            this.returnCopyButton.Name = "returnCopyButton";
            this.returnCopyButton.Size = new System.Drawing.Size(99, 23);
            this.returnCopyButton.TabIndex = 6;
            this.returnCopyButton.Text = "Return copy";
            this.returnCopyButton.UseVisualStyleBackColor = true;
            this.returnCopyButton.Click += new System.EventHandler(this.returnCopyButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Search by title";
            // 
            // borrowCopyButton
            // 
            this.borrowCopyButton.Location = new System.Drawing.Point(90, 357);
            this.borrowCopyButton.Name = "borrowCopyButton";
            this.borrowCopyButton.Size = new System.Drawing.Size(103, 23);
            this.borrowCopyButton.TabIndex = 4;
            this.borrowCopyButton.Text = "Borrow copy";
            this.borrowCopyButton.UseVisualStyleBackColor = true;
            this.borrowCopyButton.Click += new System.EventHandler(this.borrowCopyButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(459, 355);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(243, 23);
            this.searchBox.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(708, 355);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(784, 346);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedBookToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 26);
            // 
            // deleteSelectedBookToolStripMenuItem
            // 
            this.deleteSelectedBookToolStripMenuItem.Name = "deleteSelectedBookToolStripMenuItem";
            this.deleteSelectedBookToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.deleteSelectedBookToolStripMenuItem.Text = "Delete selected Book";
            this.deleteSelectedBookToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedBookToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedBookToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 26);
            // 
            // deleteSelectedBookToolStripMenuItem
            // 
            this.deleteSelectedBookToolStripMenuItem.Name = "deleteSelectedBookToolStripMenuItem";
            this.deleteSelectedBookToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.deleteSelectedBookToolStripMenuItem.Text = "Delete selected book";
            this.deleteSelectedBookToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedBookToolStripMenuItem_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(9, 357);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 0;
            this.refresh.Text = " Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Books";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.copiesTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.genreComboBox);
            this.groupBox1.Controls.Add(this.authorComboBox);
            this.groupBox1.Controls.Add(this.addBookButton);
            this.groupBox1.Controls.Add(this.shortDescBox);
            this.groupBox1.Controls.Add(this.bookTitleBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Book";
            // 
            // copiesTextBox
            // 
            this.copiesTextBox.Location = new System.Drawing.Point(142, 171);
            this.copiesTextBox.Name = "copiesTextBox";
            this.copiesTextBox.Size = new System.Drawing.Size(256, 23);
            this.copiesTextBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Copies";
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(142, 145);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(256, 23);
            this.genreComboBox.TabIndex = 10;
            // 
            // authorComboBox
            // 
            this.authorComboBox.FormattingEnabled = true;
            this.authorComboBox.Location = new System.Drawing.Point(142, 119);
            this.authorComboBox.Name = "authorComboBox";
            this.authorComboBox.Size = new System.Drawing.Size(256, 23);
            this.authorComboBox.TabIndex = 9;
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(178, 197);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(75, 23);
            this.addBookButton.TabIndex = 8;
            this.addBookButton.Text = "Add Book";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // shortDescBox
            // 
            this.shortDescBox.Location = new System.Drawing.Point(142, 47);
            this.shortDescBox.Multiline = true;
            this.shortDescBox.Name = "shortDescBox";
            this.shortDescBox.Size = new System.Drawing.Size(257, 66);
            this.shortDescBox.TabIndex = 5;
            // 
            // bookTitleBox
            // 
            this.bookTitleBox.Location = new System.Drawing.Point(142, 19);
            this.bookTitleBox.Name = "bookTitleBox";
            this.bookTitleBox.Size = new System.Drawing.Size(257, 23);
            this.bookTitleBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Short Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Title";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.authorsDataGridView);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(790, 386);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Authors";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // authorsDataGridView
            // 
            this.authorsDataGridView.AllowUserToAddRows = false;
            this.authorsDataGridView.AllowUserToDeleteRows = false;
            this.authorsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.authorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorsDataGridView.Location = new System.Drawing.Point(8, 121);
            this.authorsDataGridView.Name = "authorsDataGridView";
            this.authorsDataGridView.RowTemplate.Height = 25;
            this.authorsDataGridView.Size = new System.Drawing.Size(309, 259);
            this.authorsDataGridView.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addAuthorButton);
            this.groupBox2.Controls.Add(this.addAuthorBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 109);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Author";
            // 
            // addAuthorButton
            // 
            this.addAuthorButton.Location = new System.Drawing.Point(125, 80);
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.Size = new System.Drawing.Size(75, 23);
            this.addAuthorButton.TabIndex = 2;
            this.addAuthorButton.Text = "Add Author";
            this.addAuthorButton.UseVisualStyleBackColor = true;
            this.addAuthorButton.Click += new System.EventHandler(this.addAuthorButton_Click);
            // 
            // addAuthorBox
            // 
            this.addAuthorBox.Location = new System.Drawing.Point(142, 19);
            this.addAuthorBox.Name = "addAuthorBox";
            this.addAuthorBox.Size = new System.Drawing.Size(161, 23);
            this.addAuthorBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Author";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.genresDataGridView);
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(790, 386);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Genres";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // genresDataGridView
            // 
            this.genresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.genresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genresDataGridView.Location = new System.Drawing.Point(8, 121);
            this.genresDataGridView.Name = "genresDataGridView";
            this.genresDataGridView.RowTemplate.Height = 25;
            this.genresDataGridView.Size = new System.Drawing.Size(309, 259);
            this.genresDataGridView.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addGenreButton);
            this.groupBox3.Controls.Add(this.addGenreBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 109);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Genre";
            // 
            // addGenreButton
            // 
            this.addGenreButton.Location = new System.Drawing.Point(125, 80);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(75, 23);
            this.addGenreButton.TabIndex = 2;
            this.addGenreButton.Text = "Add";
            this.addGenreButton.UseVisualStyleBackColor = true;
            this.addGenreButton.Click += new System.EventHandler(this.addGenreButton_Click);
            // 
            // addGenreBox
            // 
            this.addGenreBox.Location = new System.Drawing.Point(142, 19);
            this.addGenreBox.Name = "addGenreBox";
            this.addGenreBox.Size = new System.Drawing.Size(161, 23);
            this.addGenreBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Genre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 414);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.authorsDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.genresDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private Button refresh;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TextBox searchBox;
        private Button searchButton;
        private GroupBox groupBox1;
        private Button addBookButton;
        private TextBox shortDescBox;
        private TextBox bookTitleBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button addAuthorButton;
        private TextBox addAuthorBox;
        private Label label5;
        private GroupBox groupBox3;
        private Label label6;
        private Button addGenreButton;
        private TextBox addGenreBox;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteSelectedBookToolStripMenuItem;
        private ComboBox genreComboBox;
        private ComboBox authorComboBox;
        private Button borrowCopyButton;
        private Label label7;
        private DataGridView authorsDataGridView;
        private DataGridView genresDataGridView;
        private TextBox copiesTextBox;
        private Label label8;
        private Button returnCopyButton;
    }
}