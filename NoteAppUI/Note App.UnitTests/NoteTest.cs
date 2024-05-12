using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;



    namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTests
    {
        private Note _note;
        [SetUp]
        public void UnitNote()
        {
            _note = new Note();
        }

        [Test(Description = "позитивный тест геттера Title")]
        public void TestTitleGet_CorrectValue()
        {
            var expected = "Без названия";
            _note.Title = expected;
            var actual = _note.Title;
            Assert.AreEqual(expected, actual, "Геттер Title возвращает неправильнo");
        }
        [TestCase("adadadadadadadadadadadadadadadadadadadadadadadadadadadadadadadadadadadadadadada",
            "Должно возникать исключение, если title длиннее 50 символов",
            TestName = "Присвоение title больше 50 символов")]
        public void TestTitleSetArgumentException(string wrongTitle, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { _note.Title = wrongTitle; },message);
        }
        [Test(Description = "тест сеттера Title на нулевое значение")]
        public void TestTitleSet_NullValue()
        {
            var expected = "";
            _note.Title = expected;
            if ("Без названия" == _note.Title) { Assert.AreEqual(expected, "Геттер Title возвращает неправильнo"); }
        }
        [Test(Description = "позитивный тест геттера Category")]
        public void TestCategoryGet_CorrectValue()
        {
            var expected = EnumNoteCategory.Job;
            _note.Category = expected;
            var actual = _note.Category;
            Assert.AreEqual(expected, actual, "Геттер Category возвращает неправильнo");
        }
        
        [Test(Description = "Положительный тест сеттера Category")]
        public void TestCategorySet_CorrectValue()
        {
            var expected = EnumNoteCategory.Job;
            _note.Category = expected;
            if (expected == EnumNoteCategory.Job || expected == EnumNoteCategory.Home
                || expected == EnumNoteCategory.HealthAndSports || expected == EnumNoteCategory.People
                || expected == EnumNoteCategory.Documents || expected == EnumNoteCategory.Finance
                || expected == EnumNoteCategory.Others) { }
            else { Assert.AreEqual(expected, "Геттер Title возвращает неправильнo"); }
        }
        [Test(Description = "позитивный тест геттера Text")]
        public void TestTextGet_CorrectValue()
        {
            var expected = ",jk,bflpowejfgiwej";
            _note.NoteText = expected;
            var actual = _note.NoteText;
            Assert.AreEqual(expected, actual, "Геттер Notetext возвращает неправильнo");
        }
        [TestCase("", "Должно возникать исключение на пустую строку тескта",
            TestName = "Присвоение пустой строки в текст")]
        public void TestTextSetNullValueException(string wrongText, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { _note.NoteText= wrongText; }, message);
        }
        [Test(Description = "позитивный тест геттера CreatingTime")]
        public void TestCreationTimeGet_CorrectValue()
        {
            Note note = new Note();
            DateTime timeCreated = DateTime.Now;
            var actual = note.CreationTime;
            var expected = timeCreated.ToString();

            
            Assert.AreEqual(expected, actual, "Геттер времени создания возвращает неправильнo");
        }
        [Test(Description = "позитивный тест геттера TimeOfLastChange")]
        public void TestTimeOfLastChangeGet_timeOfLastChange()
        {
            Note note = new Note();
            DateTime timeCreated = DateTime.Now;
            var actual = note.TimeOfLastChange;
            var expected = timeCreated.ToString();


            Assert.AreEqual(expected, actual, "Геттер времени последнего изменения возвращает неправильнo");
        }
        [Test(Description = "Тестирование констуктора без параметров.")]
        public void TestСonstructorWithoutParameters()
        {
            Assert.DoesNotThrow(() => new Note());
        }
        [Test(Description = "Тестирование констуктора с параметрами.")]
        public void TestСonstructorWithParameters()
        {
            Assert.DoesNotThrow(() => new Note(
                "Gfgfgfgfgfg",
                EnumNoteCategory.Job,
                "бла бла бла бла бла "
                ));
        }
        [Test(Description = "Тестирование метода клонирования класса.")]
        public void TestCloneContact()
        {
            _note = new Note(
                "Gfgfgfgfgfg",
                EnumNoteCategory.Job,
                "бла бла бла бла бла "
                );
            var clone = (Note)_note.Clone();
            var result = (
                clone.Title == _note.Title &&
                clone.Category == _note.Category &&
                clone.NoteText == _note.NoteText &&
                clone.CreationTime == _note.CreationTime &&
                clone.TimeOfLastChange == _note.TimeOfLastChange);
            Assert.IsTrue(result);
        }
    }
}
