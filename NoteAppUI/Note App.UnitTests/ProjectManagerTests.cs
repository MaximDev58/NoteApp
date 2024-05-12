using NoteApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_App.UnitTests
{
    internal class ProjectManagerTests
    {
        [TestFixture]
        public class SerializerTests
        {
            
            private Project project = new Project();
            private List<Note> _notes = new List<Note>();

           
            /// <summary>
            /// Положительный тест сериализации списка контактов.
            /// </summary>
            [Test]
            public void TestSerialize()
            {
                ProjectManager.SaveProject(project);
                var expected = File.ReadAllText(@"C:\NoteApp.notes");
                var actual = File.ReadAllText(@"C:\NoteApp.notes");
                Assert.AreEqual(expected, actual);
            }

            /// <summary>
            /// Положительный тест десериализации списка контактов.
            /// </summary>
            [Test]
            public void TestDeserialize()
            {
                Note note1 = new Note();
                var expected = new List<Note>();
                expected.Add(note1);
                project.AddNote(note1);
                ProjectManager.SaveProject(project);
                ProjectManager.ReadProject(project);
                var actual = project.NoteList;
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
