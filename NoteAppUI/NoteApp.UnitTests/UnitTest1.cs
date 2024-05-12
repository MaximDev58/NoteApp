
    using NUnit.Framework;
    using NoteApp;

    namespace NoteApp.UnitTests
    {
        [TestFixture]
        public class NoteTests
        {
            [Test(Description = "���������� ���� ������� Title")]
            public void TestTitleGet_CorrectValue()
            {
                var expected = "��� ��������";
                var note = new Note();
                note.Title = expected;
                var actual = note.Title;
                Assert.AreEqual(expected, note.Title);

                Assert.Pass();
            }
        }
    }
