namespace NoteAppUI
{
    partial class FormEditNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditNote));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Categorylabel = new System.Windows.Forms.Label();
            this.CreationTimeLabel = new System.Windows.Forms.Label();
            this.TimeOfLastChangeLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.EditTextGroupBox = new System.Windows.Forms.GroupBox();
            this.NoteTextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.EditTextGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(13, 13);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(57, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Название";
            // 
            // Categorylabel
            // 
            this.Categorylabel.AutoSize = true;
            this.Categorylabel.Location = new System.Drawing.Point(13, 43);
            this.Categorylabel.Name = "Categorylabel";
            this.Categorylabel.Size = new System.Drawing.Size(60, 13);
            this.Categorylabel.TabIndex = 1;
            this.Categorylabel.Text = "Категория";
            // 
            // CreationTimeLabel
            // 
            this.CreationTimeLabel.AutoSize = true;
            this.CreationTimeLabel.Location = new System.Drawing.Point(13, 76);
            this.CreationTimeLabel.Name = "CreationTimeLabel";
            this.CreationTimeLabel.Size = new System.Drawing.Size(35, 13);
            this.CreationTimeLabel.TabIndex = 2;
            this.CreationTimeLabel.Text = "label3";
            // 
            // TimeOfLastChangeLabel
            // 
            this.TimeOfLastChangeLabel.AutoSize = true;
            this.TimeOfLastChangeLabel.Location = new System.Drawing.Point(291, 76);
            this.TimeOfLastChangeLabel.Name = "TimeOfLastChangeLabel";
            this.TimeOfLastChangeLabel.Size = new System.Drawing.Size(35, 13);
            this.TimeOfLastChangeLabel.TabIndex = 3;
            this.TimeOfLastChangeLabel.Text = "label4";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(79, 10);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(550, 20);
            this.TitleTextBox.TabIndex = 4;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(79, 40);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(219, 21);
            this.CategoryComboBox.TabIndex = 5;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // EditTextGroupBox
            // 
            this.EditTextGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditTextGroupBox.Controls.Add(this.NoteTextRichTextBox);
            this.EditTextGroupBox.Location = new System.Drawing.Point(13, 93);
            this.EditTextGroupBox.Name = "EditTextGroupBox";
            this.EditTextGroupBox.Size = new System.Drawing.Size(775, 345);
            this.EditTextGroupBox.TabIndex = 6;
            this.EditTextGroupBox.TabStop = false;
            // 
            // NoteTextRichTextBox
            // 
            this.NoteTextRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextRichTextBox.Location = new System.Drawing.Point(3, 12);
            this.NoteTextRichTextBox.Name = "NoteTextRichTextBox";
            this.NoteTextRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.NoteTextRichTextBox.Size = new System.Drawing.Size(766, 327);
            this.NoteTextRichTextBox.TabIndex = 8;
            this.NoteTextRichTextBox.Text = "";
            this.NoteTextRichTextBox.TextChanged += new System.EventHandler(this.NoteTextRichTextBox_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveButton.Location = new System.Drawing.Point(251, 444);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(428, 444);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FormEditNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EditTextGroupBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TimeOfLastChangeLabel);
            this.Controls.Add(this.CreationTimeLabel);
            this.Controls.Add(this.Categorylabel);
            this.Controls.Add(this.TitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditNote";
            this.Text = "Редактирование записки";
            this.Load += new System.EventHandler(this.FormEditNote_Load);
            this.EditTextGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label Categorylabel;
        private System.Windows.Forms.Label CreationTimeLabel;
        private System.Windows.Forms.Label TimeOfLastChangeLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.GroupBox EditTextGroupBox;
        private System.Windows.Forms.RichTextBox NoteTextRichTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
    }
}