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
    /// Статический класс - менеджер проектов
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// Закрытая константа пути
        /// </summary>
        private const string _location = "C:\\Users\\Maxim Demchenko\\Documents\\NoteApp.notes";

        /// <summary>
        /// Статический метод сохранения списка заметок
        /// </summary>
        /// <param name="project"> обьект класса Project - список заметок</param>
        public static void SaveProject(Project project)
        {
            JsonSerializer serializer = new JsonSerializer();
            
            using (StreamWriter sw = new StreamWriter(@"C:\NoteApp.notes"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
            }
        }
        /// <summary>
        /// Статический метод чтения списка заметок по пути
        /// </summary>
        /// <param name="project">Объект класса Project - список заметок из файла</param>
        public static Project ReadProject(Project project)
        {
            project = null;

            JsonSerializer serializer = new JsonSerializer();
            //Открываем поток для чтения из файла с указанием пути
            using (StreamReader sr = new StreamReader(@"C:\NoteApp.notes"))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
                project = (Project)serializer.Deserialize<Project>(reader);
            }
            return project;
        }
    }
}
