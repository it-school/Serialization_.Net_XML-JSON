using System;

namespace Serialization
{
    class SerializeExample
    {
        static void Main(string[] args)
        {
            Book book = new Book { title = "Book example 1" };
            Serializer.WriteXML(book);
            Book readbook = (Book)Serializer.ReadXML();
            Console.WriteLine(readbook.title);
        }
    }
}
