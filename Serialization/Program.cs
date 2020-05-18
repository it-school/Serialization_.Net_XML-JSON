using System;

namespace Serialization
{
    class SerializeExample
    {
        static void Main(string[] args)
        {
            Book book = new Book("Book (example 1)", 512);
            Serializer.WriteXML(book);
            
            book = null;
            book = (Book)Serializer.ReadXML();
            Console.WriteLine(book);


        }
    }
}
