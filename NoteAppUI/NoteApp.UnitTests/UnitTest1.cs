
    using NUnit.Framework;
    using NoteApp;

    namespace NoteApp.UnitTests
    {
        [TestFixture]
        public class NoteTests
        {
            [Test(Description = "позитивный тест геттера Title")]
            public void TestTitleGet_CorrectValue()
            {
                var expected = "Без названия";
                var note = new Note();
                note.Title = expected;
                var actual = note.Title;
                Assert.AreEqual(expected, note.Title);

                Assert.Pass();
            }
        }
    }
