using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            Note note1 = new Note();
            Note note2 = (Note)note1.Clone();
            Project project1 = new Project();
            project1.AddNote(note1);
            project1.AddNote(note2);
            ProjectManager projMan = new ProjectManager();
            projMan.SaveProject(project1);
            projMan.ReadProject(project1);
        }
    }
}
