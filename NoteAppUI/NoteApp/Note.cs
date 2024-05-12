using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NoteApp
{
    /// <summary>
    /// Класс заметок, хранящий информацию о названии, содержании,
    /// категории, времени создании и последнего изменения.
    /// </summary>
    public class Note : ICloneable
    {
        /// <summary>
        /// Возвращает и задает название(методы отдельно,в случае пустого пишет "Без названия")
        /// </summary>
        private string _title;

        public string Title
        { 
            get { return _title; }
            set {
                _timeOfLastChange = DateTime.Now.ToString();
                if (value == "")
                {
                    _title = "Без названия";
                }

                if (value.Length > 50)
                {
                    throw new ArgumentException("Длина ограничена 50 символами");
                }
                else _title = value;
            }
        }
        public string get_title()
        {
            return _title;
        }

        public void set_title(string value)
        {
            _timeOfLastChange = DateTime.Now.ToString();
            if (value == "")
            {
                _title = "Без названия";
            }

            if (value.Length > 50)
            {
                throw new ArgumentException("Длина ограничена 50 символами");
            }
            else _title = value;
        }
        /// <summary>
        /// Возвращает и задает категорию согласно списку категорий(методы отдельно)
        /// </summary>
        private EnumNoteCategory _category;
        public EnumNoteCategory Category { 
            get { return _category; } set {
                if (value == EnumNoteCategory.Job || value == EnumNoteCategory.Home
                || value == EnumNoteCategory.HealthAndSports || value == EnumNoteCategory.People
                || value == EnumNoteCategory.Documents || value == EnumNoteCategory.Finance
                || value == EnumNoteCategory.Others)
                {
                    _category = value;
                    _timeOfLastChange = DateTime.Now.ToString();
                }
                else
                {
                    throw new ArgumentException("Категория должна быть выбрана из списка");
                }
            }
        }

        public EnumNoteCategory get_category() { return _category; }

        public void set_category(EnumNoteCategory value)
        {
            if (value == EnumNoteCategory.Job || value == EnumNoteCategory.Home 
                || value == EnumNoteCategory.HealthAndSports || value == EnumNoteCategory.People
                || value == EnumNoteCategory.Documents || value == EnumNoteCategory.Finance
                || value == EnumNoteCategory.Others)
            {
                _category = value;
                _timeOfLastChange = DateTime.Now.ToString();
            }
            else
            {
                throw new ArgumentException("Категория должна быть выбрана из списка");
            }
        }
        /// <summary>
        /// Возвращает и задает текст заметки(методы отдельно)
        /// </summary>
        private string _noteText;
        public string NoteText {
            set {
                if (value == "")
                {
                    throw new ArgumentException("Строка не может быть пустой");
                }
                else _noteText = value;
                _timeOfLastChange = DateTime.Now.ToString();
            } 
            get { return _noteText; }
        }
        public string get_noteText()
        {
            return _noteText;
        }

        public void set_noteText(string value)
        {

            if (value == "")
            {
                throw new ArgumentException("Строка не может быть пустой");
            }
            else _noteText = value;
            _timeOfLastChange = DateTime.Now.ToString();
        }
        /// <summary>
        /// Возвращает время создания (метод отдельно, задается при создании заметки)
        /// </summary>
        private string _creationTime;
        public string CreationTime 
        { 
            get { return _creationTime; }
        }

        public string get_creationTime()
        {
            return _creationTime;
        }

        /// <summary>
        /// Возвращает время последнего изменения (метод отдельно, задается в каждом сеттере класса и при создании)
        /// </summary>
        private string _timeOfLastChange;
        public string TimeOfLastChange { get { return _timeOfLastChange; } }

        public string get_timeOfLastChange()
        {
            return _timeOfLastChange;
        }

        /// <summary>
        /// Метод клонирования заметки
        /// </summary>
        /// <returns> Возвращает новую, эдентичную старой заметку</returns>
        public object Clone()
        {
            return new Note
            {
                _title = this._title,
                _category = this._category,
                _noteText = this._noteText,
                _creationTime = this._creationTime,
                _timeOfLastChange = DateTime.Now.ToString()
            };
        }
        
        /// <summary>
        /// конструктор
        /// </summary>
        public Note()
        {
            _title = "Без названия";
            _creationTime = DateTime.Now.ToString();
            _timeOfLastChange = DateTime.Now.ToString();
            _noteText = "fkkfkfkffkkfkfffffffffkfkkfkffkfkfkfkkfkfkfkfkfkfkfkfkfkfkfkfkfkfkfkfkfkfkfkk\n" +
                        "jgjggjgjgjgjgjgjgjggjgjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjgj\n";

        }
        public Note(string title, EnumNoteCategory category, string noteText)
        {
            Title = title;
            
            Category = category;

            NoteText = noteText;
        }

        public override string ToString()
        {
            return $"{_title}";
        }
        /// <summary>
        /// деконструктор
        /// </summary>
        ~Note()
        {
            Console.WriteLine("Заметка удалена");
        }
    }
}
