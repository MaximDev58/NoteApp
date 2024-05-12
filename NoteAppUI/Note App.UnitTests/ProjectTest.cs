using NoteApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_App.UnitTests
{
    [TestFixture]
    internal class ProjectTest
    {
        private Project project;
        [SetUp]
        public void UnitProject()
        {
            project = new Project();
        }
        [Test(Description = "позитивный тест геттера noteList")]
        public void TestNoteListGet_CorrectValue()
        {
            List<Note> expected = new List<Note>();
            project.NoteList = expected;
            var actual = project.NoteList;
            Assert.AreEqual(expected, actual, "Геттер noteList возвращает неправильнo");
        }
        [Test(Description = "позитивный тест сеттера noteList")]
        public void TestNoteListSet_CorrectValue()
        {
            List<Note> expected = new List<Note>();
            project.NoteList = expected;
            var actual = project.NoteList;
            Assert.AreEqual(expected, actual, "Cеттер noteList возвращает неправильнo");
        }
        [Test(Description = "тест метода addNote")]
        public void TestAddNote()
        {
            var note = new Note();
            List<Note> expected = new List<Note>();
            expected.Add(note);
            project.AddNote(note);
            var actual = project.NoteList;
            Assert.AreEqual(expected, actual, "addNote работает неправильнo");
        }
        [Test(Description = "тест метода RemoveNote")]
        public void TestRemoveNote()
        {
            var note1 = new Note();
            var note2 = new Note();
            List<Note> expected = new List<Note>();
            expected.Add((Note)note1);
            expected.Add((Note)note2);
            project.NoteList.Add(note1);
            project.NoteList.Add(note2);
            expected.Remove(note2);
            project.RemoveNote(note2);
            var actual = project.NoteList;
            Assert.AreEqual(expected, actual, "RemoveNote работает неправильнo");
        }
        [Test(Description = "Тестирование констуктора без параметров.")]
        public void TestСonstructorWithoutParameters()
        {
            Assert.DoesNotThrow(() => new Project());
        }
    }
}
