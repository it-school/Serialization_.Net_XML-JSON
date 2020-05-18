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
            System.IO.StreamReader file = new System.IO.StreamReader(@"d:\book.xml");
            Book overview = (Book)reader.Deserialize(file);
            file.Close();
            return overview;
        }


        //public  static async void WriteJSON(Object obj) // сохранение данных
        //{
        //    using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
        //    {
        //        Book book = new Book();
        //        await JsonSerializer.SerializeAsync<Book>(fs, book);
        //        Console.WriteLine("Data has been saved to file");
        //    }
        //}
        //public static async Object ReadJSON()      // запись данных
        //{
        //    Object result = null;
        //    using (FileStream fs = new FileStream("book.json", FileMode.OpenOrCreate))
        //    {
        //        result = await JsonSerializer.DeserializeAsync<Book>(fs);
        //        Console.WriteLine($"Name: {restoredPerson.Name}  Age: {restoredPerson.Age}");
        //    }

        //    return result;
        //}
    }
}
