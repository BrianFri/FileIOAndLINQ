namespace FileIOAndLINQ.PresentationLayer
{
    partial class FrmVerseList
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
            mnsFileActions = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            grpAddVerse = new GroupBox();
            lblImportanceError = new Label();
            lblTextError = new Label();
            lblChapterError = new Label();
            lblMeaningError = new Label();
            lblVerseError = new Label();
            lblBookError = new Label();
            btnAddVerse = new Button();
            nudVerseImportance = new NumericUpDown();
            txtVerseMeaning = new TextBox();
            txtVerseText = new TextBox();
            txtVerseVerse = new TextBox();
            txtVerseChapter = new TextBox();
            cmbVerseBook = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            rdoShowMostValuable = new RadioButton();
            rdoShowLeastValuable = new RadioButton();
            rdoShowAll = new RadioButton();
            trbNumberToShow = new TrackBar();
            mnsFileActions.SuspendLayout();
            grpAddVerse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudVerseImportance).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbNumberToShow).BeginInit();
            SuspendLayout();
            // 
            // mnsFileActions
            // 
            mnsFileActions.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            mnsFileActions.Location = new Point(0, 0);
            mnsFileActions.Name = "mnsFileActions";
            mnsFileActions.Size = new Size(836, 24);
            mnsFileActions.TabIndex = 0;
            mnsFileActions.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(100, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(100, 22);
            loadToolStripMenuItem.Text = "Load";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(100, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // grpAddVerse
            // 
            grpAddVerse.Controls.Add(lblImportanceError);
            grpAddVerse.Controls.Add(lblTextError);
            grpAddVerse.Controls.Add(lblChapterError);
            grpAddVerse.Controls.Add(lblMeaningError);
            grpAddVerse.Controls.Add(lblVerseError);
            grpAddVerse.Controls.Add(lblBookError);
            grpAddVerse.Controls.Add(btnAddVerse);
            grpAddVerse.Controls.Add(nudVerseImportance);
            grpAddVerse.Controls.Add(txtVerseMeaning);
            grpAddVerse.Controls.Add(txtVerseText);
            grpAddVerse.Controls.Add(txtVerseVerse);
            grpAddVerse.Controls.Add(txtVerseChapter);
            grpAddVerse.Controls.Add(cmbVerseBook);
            grpAddVerse.Controls.Add(label6);
            grpAddVerse.Controls.Add(label5);
            grpAddVerse.Controls.Add(label4);
            grpAddVerse.Controls.Add(label3);
            grpAddVerse.Controls.Add(label2);
            grpAddVerse.Controls.Add(label1);
            grpAddVerse.Location = new Point(12, 27);
            grpAddVerse.Name = "grpAddVerse";
            grpAddVerse.Size = new Size(345, 591);
            grpAddVerse.TabIndex = 1;
            grpAddVerse.TabStop = false;
            grpAddVerse.Text = "Add A Bible Verse";
            // 
            // lblImportanceError
            // 
            lblImportanceError.AutoSize = true;
            lblImportanceError.ForeColor = Color.Red;
            lblImportanceError.Location = new Point(92, 528);
            lblImportanceError.Name = "lblImportanceError";
            lblImportanceError.Size = new Size(96, 15);
            lblImportanceError.TabIndex = 18;
            lblImportanceError.Text = "Importance Error";
            // 
            // lblTextError
            // 
            lblTextError.AutoSize = true;
            lblTextError.ForeColor = Color.Red;
            lblTextError.Location = new Point(92, 312);
            lblTextError.Name = "lblTextError";
            lblTextError.Size = new Size(56, 15);
            lblTextError.TabIndex = 17;
            lblTextError.Text = "Text Error";
            // 
            // lblChapterError
            // 
            lblChapterError.AutoSize = true;
            lblChapterError.ForeColor = Color.Red;
            lblChapterError.Location = new Point(92, 116);
            lblChapterError.Name = "lblChapterError";
            lblChapterError.Size = new Size(77, 15);
            lblChapterError.TabIndex = 16;
            lblChapterError.Text = "Chapter Error";
            // 
            // lblMeaningError
            // 
            lblMeaningError.AutoSize = true;
            lblMeaningError.ForeColor = Color.Red;
            lblMeaningError.Location = new Point(92, 475);
            lblMeaningError.Name = "lblMeaningError";
            lblMeaningError.Size = new Size(82, 15);
            lblMeaningError.TabIndex = 15;
            lblMeaningError.Text = "Meaning Error";
            // 
            // lblVerseError
            // 
            lblVerseError.AutoSize = true;
            lblVerseError.ForeColor = Color.Red;
            lblVerseError.Location = new Point(92, 166);
            lblVerseError.Name = "lblVerseError";
            lblVerseError.Size = new Size(62, 15);
            lblVerseError.TabIndex = 14;
            lblVerseError.Text = "Verse Error";
            // 
            // lblBookError
            // 
            lblBookError.AutoSize = true;
            lblBookError.ForeColor = Color.Red;
            lblBookError.Location = new Point(92, 66);
            lblBookError.Name = "lblBookError";
            lblBookError.Size = new Size(62, 15);
            lblBookError.TabIndex = 13;
            lblBookError.Text = "Book Error";
            // 
            // btnAddVerse
            // 
            btnAddVerse.Location = new Point(158, 559);
            btnAddVerse.Name = "btnAddVerse";
            btnAddVerse.Size = new Size(75, 23);
            btnAddVerse.TabIndex = 12;
            btnAddVerse.Text = "Add";
            btnAddVerse.UseVisualStyleBackColor = true;
            // 
            // nudVerseImportance
            // 
            nudVerseImportance.Location = new Point(92, 493);
            nudVerseImportance.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudVerseImportance.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudVerseImportance.Name = "nudVerseImportance";
            nudVerseImportance.Size = new Size(216, 23);
            nudVerseImportance.TabIndex = 11;
            nudVerseImportance.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudVerseImportance.Leave += NudVerseImportanceLeaveEH;
            // 
            // txtVerseMeaning
            // 
            txtVerseMeaning.Location = new Point(92, 347);
            txtVerseMeaning.Multiline = true;
            txtVerseMeaning.Name = "txtVerseMeaning";
            txtVerseMeaning.Size = new Size(216, 119);
            txtVerseMeaning.TabIndex = 10;
            txtVerseMeaning.Leave += TxtVerseMeaningLeaveEH;
            // 
            // txtVerseText
            // 
            txtVerseText.Location = new Point(92, 190);
            txtVerseText.Multiline = true;
            txtVerseText.Name = "txtVerseText";
            txtVerseText.Size = new Size(216, 119);
            txtVerseText.TabIndex = 9;
            txtVerseText.Leave += TxtVerseTextLeaveEH;
            // 
            // txtVerseVerse
            // 
            txtVerseVerse.Location = new Point(92, 140);
            txtVerseVerse.Name = "txtVerseVerse";
            txtVerseVerse.Size = new Size(216, 23);
            txtVerseVerse.TabIndex = 8;
            txtVerseVerse.Leave += TxtVerseVerseLeaveEH;
            // 
            // txtVerseChapter
            // 
            txtVerseChapter.Location = new Point(92, 90);
            txtVerseChapter.Name = "txtVerseChapter";
            txtVerseChapter.Size = new Size(216, 23);
            txtVerseChapter.TabIndex = 7;
            txtVerseChapter.Leave += TxtVerseChapterLeaveEH;
            // 
            // cmbVerseBook
            // 
            cmbVerseBook.FormattingEnabled = true;
            cmbVerseBook.Location = new Point(92, 40);
            cmbVerseBook.Name = "cmbVerseBook";
            cmbVerseBook.Size = new Size(216, 23);
            cmbVerseBook.TabIndex = 6;
            cmbVerseBook.Leave += CmbVerseBookLeaveEH;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 495);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 5;
            label6.Text = "Importance:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 350);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "Meaning:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 193);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "Text:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 143);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Verse:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 93);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Chapter:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 43);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Book:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoShowMostValuable);
            groupBox1.Controls.Add(rdoShowLeastValuable);
            groupBox1.Controls.Add(rdoShowAll);
            groupBox1.Location = new Point(12, 624);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 141);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter And Sort";
            // 
            // rdoShowMostValuable
            // 
            rdoShowMostValuable.AutoSize = true;
            rdoShowMostValuable.Location = new Point(6, 100);
            rdoShowMostValuable.Name = "rdoShowMostValuable";
            rdoShowMostValuable.Size = new Size(131, 19);
            rdoShowMostValuable.TabIndex = 2;
            rdoShowMostValuable.TabStop = true;
            rdoShowMostValuable.Text = "Show Most Valuable";
            rdoShowMostValuable.UseVisualStyleBackColor = true;
            // 
            // rdoShowLeastValuable
            // 
            rdoShowLeastValuable.AutoSize = true;
            rdoShowLeastValuable.Location = new Point(6, 60);
            rdoShowLeastValuable.Name = "rdoShowLeastValuable";
            rdoShowLeastValuable.Size = new Size(131, 19);
            rdoShowLeastValuable.TabIndex = 1;
            rdoShowLeastValuable.TabStop = true;
            rdoShowLeastValuable.Text = "Show Least Valuable";
            rdoShowLeastValuable.UseVisualStyleBackColor = true;
            // 
            // rdoShowAll
            // 
            rdoShowAll.AutoSize = true;
            rdoShowAll.Location = new Point(6, 20);
            rdoShowAll.Name = "rdoShowAll";
            rdoShowAll.Size = new Size(71, 19);
            rdoShowAll.TabIndex = 0;
            rdoShowAll.TabStop = true;
            rdoShowAll.Text = "Show All";
            rdoShowAll.UseVisualStyleBackColor = true;
            // 
            // trbNumberToShow
            // 
            trbNumberToShow.Location = new Point(12, 771);
            trbNumberToShow.Name = "trbNumberToShow";
            trbNumberToShow.Size = new Size(345, 45);
            trbNumberToShow.TabIndex = 3;
            // 
            // FrmVerseList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 894);
            Controls.Add(trbNumberToShow);
            Controls.Add(groupBox1);
            Controls.Add(grpAddVerse);
            Controls.Add(mnsFileActions);
            MainMenuStrip = mnsFileActions;
            Name = "FrmVerseList";
            Text = "Bible Verses";
            mnsFileActions.ResumeLayout(false);
            mnsFileActions.PerformLayout();
            grpAddVerse.ResumeLayout(false);
            grpAddVerse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudVerseImportance).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trbNumberToShow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnsFileActions;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private GroupBox grpAddVerse;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtVerseText;
        private TextBox txtVerseVerse;
        private TextBox txtVerseChapter;
        private ComboBox cmbVerseBook;
        private TextBox txtVerseMeaning;
        private Button btnAddVerse;
        private NumericUpDown nudVerseImportance;
        private Label lblImportanceError;
        private Label lblTextError;
        private Label lblChapterError;
        private Label lblMeaningError;
        private Label lblVerseError;
        private Label lblBookError;
        private GroupBox groupBox1;
        private RadioButton rdoShowAll;
        private RadioButton rdoShowMostValuable;
        private RadioButton rdoShowLeastValuable;
        private TrackBar trbNumberToShow;
    }
}