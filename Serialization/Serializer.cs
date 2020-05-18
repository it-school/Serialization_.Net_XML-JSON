using Newtonsoft.Json;
using System;
using System.IO;

namespace Serialization
{
    public static class Serializer
    {
        public static void WriteXML(Object obj)
        {
            Book overview = (Book)obj;
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(Book));

            //var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//book.xml";
            var path = @"d:\book.xml";
            FileStream file = File.Create(path);

            writer.Serialize(file, overview);
            file.Close();
        }

        public static Object ReadXML()
        {
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(Book));
            StreamReader file = new System.IO.StreamReader(@"d:\book.xml");
            Book overview = (Book)reader.Deserialize(file);
            file.Close();
            return overview;
        }

        public static void WriteJSON(Object obj, string path = @"d:\book.json") // сохранение данных
        {
            StreamWriter file = new StreamWriter(path);
            string result = JsonConvert.SerializeObject(obj);
            file.Write(result);
            file.Close();
        }
        public static Object ReadJSON(string path = @"d:\book.json")      // запись данных
        {
            StreamReader file = new System.IO.StreamReader(path);
            FileStream fs = new FileStream("book.json", FileMode.OpenOrCreate);

            Object result = JsonConvert.DeserializeObject(file.ReadToEnd());                

            file.Close();

            return result;
        }
    }
}
