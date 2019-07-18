using System;

namespace Serialization
{
    public static class Serializer
    {
        public static void WriteXML(Object obj)
        {
            Book overview = (Book)obj;
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(Book));

            //var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//book.xml";
            var path = @"d:\txt\book.xml";
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, overview);
            file.Close();
        }

        public static Object ReadXML()
        {
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(Book));
            System.IO.StreamReader file = new System.IO.StreamReader(@"d:\txt\book.xml");
            Book overview = (Book)reader.Deserialize(file);
            file.Close();
            return overview;
        }
    }
}
