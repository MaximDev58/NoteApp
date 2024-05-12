using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using NoteApp;

namespace NoteAppUI
{
    public partial class FormEditNote : Form
    {
        
        private Note editNote;
        private Note cancleNote = new Note();


        public Note Note
        { 
            get
            {
                return editNote;
            }
            set
            {
                editNote = value; 
                if (editNote != null)
                {
                    TitleTextBox.Text = editNote.get_title();
                    CategoryComboBox.SelectedItem = editNote.get_category();
                    CreationTimeLabel.Text = editNote.get_creationTime();
                    TimeOfLastChangeLabel.Text = editNote.get_timeOfLastChange();
                    NoteTextRichTextBox.Text = editNote.get_noteText();
                    cancleNote.set_title(editNote.get_title());
                    cancleNote.set_noteText(editNote.get_noteText());
                    cancleNote.set_category(editNote.get_category());
                }
            }
        }
        

        public FormEditNote()
        {
            InitializeComponent();
            CategoryComboBox.Items.Add(EnumNoteCategory.Job);
            CategoryComboBox.Items.Add(EnumNoteCategory.Home);
            CategoryComboBox.Items.Add(EnumNoteCategory.HealthAndSports);
            CategoryComboBox.Items.Add(EnumNoteCategory.People);
            CategoryComboBox.Items.Add(EnumNoteCategory.Documents);
            CategoryComboBox.Items.Add(EnumNoteCategory.Finance);
            CategoryComboBox.Items.Add(EnumNoteCategory.Others);
             
        }
       
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void FormEditNote_Load(object sender, EventArgs e)
        {
            
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            editNote.set_category((EnumNoteCategory)CategoryComboBox.SelectedItem);
            TimeOfLastChangeLabel.Text = editNote.get_timeOfLastChange();
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (TitleTextBox.TextLength > 50)
            {
                TitleTextBox.BackColor = Color.Firebrick;
            }
            else
            {
                TitleTextBox.BackColor = Color.White;
                
            }
            editNote.set_title(TitleTextBox.Text);
            TimeOfLastChangeLabel.Text = editNote.get_timeOfLastChange();
        }

        private void NoteTextRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NoteTextRichTextBox.Text == "")
            {
                NoteTextRichTextBox.BackColor = Color.Red;
            }
            else
            {
                NoteTextRichTextBox.BackColor = Color.White;
                editNote.set_noteText(NoteTextRichTextBox.Text);
                TimeOfLastChangeLabel.Text = editNote.get_timeOfLastChange();
            }
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            editNote.set_title(cancleNote.get_title());
            editNote.set_noteText(cancleNote.get_noteText());  
            editNote.set_category(cancleNote.get_category());
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
