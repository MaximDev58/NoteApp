namespace NoteAppUI
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NoteListBox = new System.Windows.Forms.ListBox();
            this.NULabel = new System.Windows.Forms.Label();
            this.CategotyComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CreationTimeLabel = new System.Windows.Forms.Label();
            this.TimeOfLastChangeLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.NoteTextLabelScrollBar = new System.Windows.Forms.VScrollBar();
            this.NoteTextLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.addNoteToolStripMenuItem1,
            this.removeNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Image = global::NoteAppUI.Properties.Resources.free_icon_plus_3303893;
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.addNoteToolStripMenuItem.Text = "Add Note";
            this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // addNoteToolStripMenuItem1
            // 
            this.addNoteToolStripMenuItem1.Image = global::NoteAppUI.Properties.Resources.free_icon_pencil_1024143;
            this.addNoteToolStripMenuItem1.Name = "addNoteToolStripMenuItem1";
            this.addNoteToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.addNoteToolStripMenuItem1.Text = "Edit Note";
            // 
            // removeNoteToolStripMenuItem
            // 
            this.removeNoteToolStripMenuItem.Image = global::NoteAppUI.Properties.Resources.free_icon_close_cross_in_circular_outlined_interface_button_58253;
            this.removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
            this.removeNoteToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.removeNoteToolStripMenuItem.Text = "Remove Note";
            this.removeNoteToolStripMenuItem.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // NoteListBox
            // 
            this.NoteListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NoteListBox.FormattingEnabled = true;
            this.NoteListBox.Location = new System.Drawing.Point(16, 69);
            this.NoteListBox.Name = "NoteListBox";
            this.NoteListBox.Size = new System.Drawing.Size(188, 316);
            this.NoteListBox.TabIndex = 1;
            this.NoteListBox.SelectedIndexChanged += new System.EventHandler(this.NoteListBox_SelectedIndexChanged);
            // 
            // NULabel
            // 
            this.NULabel.AutoSize = true;
            this.NULabel.Location = new System.Drawing.Point(13, 28);
            this.NULabel.Name = "NULabel";
            this.NULabel.Size = new System.Drawing.Size(81, 13);
            this.NULabel.TabIndex = 2;
            this.NULabel.Text = "Show category:";
            // 
            // CategotyComboBox
            // 
            this.CategotyComboBox.FormattingEnabled = true;
            this.CategotyComboBox.Location = new System.Drawing.Point(100, 27);
            this.CategotyComboBox.Name = "CategotyComboBox";
            this.CategotyComboBox.Size = new System.Drawing.Size(130, 21);
            this.CategotyComboBox.TabIndex = 3;
            this.CategotyComboBox.SelectedIndexChanged += new System.EventHandler(this.CategotyComboBox_SelectedIndexChanged);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(270, 56);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(49, 13);
            this.CategoryLabel.TabIndex = 5;
            this.CategoryLabel.Text = "Category";
            // 
            // CreationTimeLabel
            // 
            this.CreationTimeLabel.AutoSize = true;
            this.CreationTimeLabel.Location = new System.Drawing.Point(270, 85);
            this.CreationTimeLabel.Name = "CreationTimeLabel";
            this.CreationTimeLabel.Size = new System.Drawing.Size(69, 13);
            this.CreationTimeLabel.TabIndex = 6;
            this.CreationTimeLabel.Text = "CreationTime";
            // 
            // TimeOfLastChangeLabel
            // 
            this.TimeOfLastChangeLabel.AutoSize = true;
            this.TimeOfLastChangeLabel.Location = new System.Drawing.Point(270, 113);
            this.TimeOfLastChangeLabel.Name = "TimeOfLastChangeLabel";
            this.TimeOfLastChangeLabel.Size = new System.Drawing.Size(98, 13);
            this.TimeOfLastChangeLabel.TabIndex = 7;
            this.TimeOfLastChangeLabel.Text = "TimeOfLastChange";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(270, 28);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 13;
            this.TitleLabel.Text = "Title";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.NoteTextLabelScrollBar);
            this.groupBox1.Controls.Add(this.NoteTextLabel);
            this.groupBox1.Location = new System.Drawing.Point(262, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 402);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.Image = global::NoteAppUI.Properties.Resources.free_icon_plus_3303893__1_;
            this.AddButton.Location = new System.Drawing.Point(12, 486);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(45, 45);
            this.AddButton.TabIndex = 12;
            this.AddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveButton.Image = global::NoteAppUI.Properties.Resources.free_icon_close_cross_in_circula;
            this.RemoveButton.Location = new System.Drawing.Point(114, 486);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(45, 45);
            this.RemoveButton.TabIndex = 11;
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditButton.Image = global::NoteAppUI.Properties.Resources.free_icon_pencil_1024143__1_;
            this.EditButton.Location = new System.Drawing.Point(63, 486);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(45, 45);
            this.EditButton.TabIndex = 10;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // NoteTextLabelScrollBar
            // 
            this.NoteTextLabelScrollBar.Location = new System.Drawing.Point(575, 16);
            this.NoteTextLabelScrollBar.Name = "NoteTextLabelScrollBar";
            this.NoteTextLabelScrollBar.Size = new System.Drawing.Size(18, 383);
            this.NoteTextLabelScrollBar.TabIndex = 1;
            this.NoteTextLabelScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.NoteTextLabelScrollBar_Scroll);
            // 
            // NoteTextLabel
            // 
            this.NoteTextLabel.Location = new System.Drawing.Point(0, 16);
            this.NoteTextLabel.Name = "NoteTextLabel";
            this.NoteTextLabel.Size = new System.Drawing.Size(572, 383);
            this.NoteTextLabel.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 543);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.TimeOfLastChangeLabel);
            this.Controls.Add(this.CreationTimeLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.CategotyComboBox);
            this.Controls.Add(this.NULabel);
            this.Controls.Add(this.NoteListBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "NoteApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox NoteListBox;
        private System.Windows.Forms.Label NULabel;
        private System.Windows.Forms.ComboBox CategotyComboBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label CreationTimeLabel;
        private System.Windows.Forms.Label TimeOfLastChangeLabel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.VScrollBar NoteTextLabelScrollBar;
        private System.Windows.Forms.Label NoteTextLabel;
    }
}

