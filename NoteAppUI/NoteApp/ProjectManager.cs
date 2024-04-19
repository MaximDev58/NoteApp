using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{ 
    /// <summary>
    /// Класс - менеджер проектов
    /// </summary>
    public class ProjectManager
    {
        /// <summary>
        /// Закрытая константа пути
        /// </summary>
        private const string _location = "C:\\Users\\Maxim Demchenko\\Documents\\NoteApp.notes";

        /// <summary>
        /// Метод сохранения списка заметок
        /// </summary>
        /// <param name="project"> обьект класса Project - список заметок</param>
        public void SaveProject(Project project)
        {
            JsonSerializer serializer = new JsonSerializer();
            
            using (StreamWriter sw = new StreamWriter(@_location))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
            }
        }
        /// <summary>
        /// метод чтения списка заметок по пути
        /// </summary>
        /// <param name="project">Объект класса Project - список заметок из файла</param>
        public void ReadProject(Project project)
        {
            JsonSerializer serializer = new JsonSerializer();
            //Открываем поток для чтения из файла с указанием пути
            using (StreamReader sr = new StreamReader(@_location))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                project = (Project)serializer.Deserialize<Project>(reader);
            }
        }
    }
}
