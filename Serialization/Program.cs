using System;

namespace Serialization
{
    class SerializeExample
    {
        static void Main(string[] args)
        {
            Book book = new Book("Book (example 1)", 512);

            // XML serialization / deserialization            
            Serializer.WriteXML(book);
            
            book = null;
            book = (Book)Serializer.ReadXML();
            Console.WriteLine(book);


            // JSON serialization / deserialization
            Serializer.WriteJSON(book, @"d:\book.json");
            Console.WriteLine(  Serializer.ReadJSON(@"d:\book.json"));
        }
    }
}
