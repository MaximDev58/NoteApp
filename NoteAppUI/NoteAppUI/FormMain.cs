using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using NoteApp;

namespace NoteAppUI
{
    public partial class FormMain : Form
    {
        Project project = new Project();
        public FormMain()
        {
            InitializeComponent();
            CategotyComboBox.Items.Add("All");
            CategotyComboBox.Items.Add(EnumNoteCategory.Job);
            CategotyComboBox.Items.Add(EnumNoteCategory.Home);
            CategotyComboBox.Items.Add(EnumNoteCategory.HealthAndSports);
            CategotyComboBox.Items.Add(EnumNoteCategory.People);
            CategotyComboBox.Items.Add(EnumNoteCategory.Documents);
            CategotyComboBox.Items.Add(EnumNoteCategory.Finance);
            CategotyComboBox.Items.Add(EnumNoteCategory.Others);
            
        }


        private void FormMain_Load(object sender, EventArgs e)
        {            
            project = ProjectManager.ReadProject(project);            
            TitleLabel.Text = $"Название: {project.SelectedNote.get_title()}";
            CategoryLabel.Text = $"Категория: {project.SelectedNote.get_category()}";
            CreationTimeLabel.Text = $"Время создания заметки: {project.SelectedNote.get_creationTime()}";
            TimeOfLastChangeLabel.Text = $"Время последнего изменения заметки: {project.SelectedNote.get_timeOfLastChange()}";
            NoteTextLabel.Text = $"{project.SelectedNote.get_noteText()}";
            foreach (Note note in project.get_noteList())
            {
                NoteListBox.Items.Add(note);
                NoteListBox.DisplayMember = note.ToString();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout.fa.ShowForm();
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
            ProjectManager.SaveProject(project);
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Note note = new Note();
            project.AddNote(note);
            NoteListBox.Items.Add(note);
            NoteListBox.DisplayMember = note.ToString();
        }

        private void NoteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (NoteListBox.SelectedItem != null)
            {
                Note selectedNote =
                    (Note)NoteListBox
                        .SelectedItem;
                project.SelectedNote = (Note)NoteListBox.SelectedItem;
                TitleLabel.Text = $"Название: {selectedNote.get_title()}";
                CategoryLabel.Text = $"Категория: {selectedNote.get_category()}";
                CreationTimeLabel.Text = $"Время создания заметки: {selectedNote.get_creationTime()}";
                TimeOfLastChangeLabel.Text = $"Время последнего изменения заметки: {selectedNote.get_timeOfLastChange()}";
                NoteTextLabel.Text = $"{selectedNote.get_noteText()}";
            }
        }
        private void NoteTextLabelScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            NoteTextLabel.Top = -NoteTextLabelScrollBar.Value;
            NoteTextLabel.Invalidate();
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {

            if (NoteListBox.SelectedItem != null)
            {
                Note selectedNote =
                    (Note)NoteListBox
                        .SelectedItem; 
                project.RemoveNote(selectedNote);
                NoteListBox.Items.Remove(selectedNote);
            }
            
        }


        private void CategotyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NoteListBox.Items.Clear();
            if (CategotyComboBox.SelectedItem == "All")
            {
                foreach (Note note in project.get_noteList())
                {
                    NoteListBox.Items.Add(note);
                    NoteListBox.DisplayMember = note.ToString();
                }
            }
            else
            {
                foreach (Note note in project.get_noteList())
                {
                    if (note.get_category().ToString() == CategotyComboBox.SelectedItem.ToString())
                    {
                        NoteListBox.Items.Add(note);
                        NoteListBox.DisplayMember = note.ToString();
                    }
                }
            }

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (NoteListBox.SelectedItem != null)
            {
                var selectedIndex = NoteListBox.SelectedIndex;
                var selectedData = project.get_noteList()[selectedIndex];
                var inner = new FormEditNote(); //Создаем форму
                inner.Note = selectedData; //Передаем форме данные
                inner.ShowDialog(); //Отображаем форму для редактирования
                var updatedData = inner.Note; //Забираем измененные данные
                //Осталось удалить старые данные по выбранному индексу
                // и заменить их на обновленные
                NoteListBox.Items.RemoveAt(selectedIndex);
                project.AddNote(updatedData);
                project.get_noteList().RemoveAt(selectedIndex);
                NoteListBox.Items.Clear();

                if (CategotyComboBox.SelectedItem == null)
                {
                    foreach (Note note in project.get_noteList())
                    {
                        NoteListBox.Items.Add(note);
                        NoteListBox.DisplayMember = note.ToString();
                    }
                }
                if (CategotyComboBox.SelectedItem == "All")
                {
                    foreach (Note note in project.get_noteList())
                    {
                        NoteListBox.Items.Add(note);
                        NoteListBox.DisplayMember = note.ToString();
                    }
                }
                else
                {
                    foreach (Note note in project.get_noteList())
                    {
                        if (note.get_category().ToString() == CategotyComboBox.SelectedItem.ToString())
                        {
                            NoteListBox.Items.Add(note);
                            NoteListBox.DisplayMember = note.ToString();
                        }
                    }
                }
            }

        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            NoteListBox.Items.Clear();
            project.SortByTime();
            if (CategotyComboBox.SelectedItem == null)
            {
                foreach (Note note in project.get_noteList())
                {
                    NoteListBox.Items.Add(note);
                    NoteListBox.DisplayMember = note.ToString();
                }
            }
            if (CategotyComboBox.SelectedItem == "All")
            {
                foreach (Note note in project.get_noteList())
                {
                    NoteListBox.Items.Add(note);
                    NoteListBox.DisplayMember = note.ToString();
                }
            }
            else
            {
                foreach (Note note in project.get_noteList())
                {
                    if (note.get_category().ToString() == CategotyComboBox.SelectedItem.ToString())
                    {
                        NoteListBox.Items.Add(note);
                        NoteListBox.DisplayMember = note.ToString();
                    }
                }
            }
        }
    }
}
