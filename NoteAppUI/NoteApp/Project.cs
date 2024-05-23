using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс проекта, содержащий список заметок
    /// </summary>
    public class Project
    {
        /// <summary>
        /// список заметок и сеттер отдельной функцией
        /// </summary>
        private List<Note> _noteList;
        public List<Note> NoteList { get { return _noteList; } set { _noteList = value; } }

        public List<Note> get_noteList()
        {
            return _noteList;
        }
        public void set_noteList(List<Note> value)
        {
            _noteList = value;
        }
        private Note _selectedNote;
        public Note SelectedNote { get { return _selectedNote; } set { _selectedNote = value; } }
        /// <summary>
        /// конструктор
        /// </summary>
        public Project()
        {
            _noteList = new List<Note>();
        }
        /// <summary>
        /// Деконструктор
        /// </summary>
        ~Project()
        {
            _noteList.Clear();
        }
        /// <summary>
        /// Сортировка по времени изменения
        /// </summary>
        /// <returns></returns>
        public void SortByTime()
        {
            _noteList.OrderByDescending(x => x.TimeOfLastChange).ToList();
        }
  
        /// <summary>
        /// Добавляет новую заметку в список
        /// </summary>
        /// <param name="note">Новая заметка</param>
        public void AddNote(Note note)
        {
            _noteList.Add(note);
        }
        public void RemoveNote(Note note)
        {
            _noteList.Remove(note);
        }
    }
}
