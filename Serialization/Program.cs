namespace Serialization
{
    class SerializeExample
    {
        static void Main(string[] args)
        {
            Book book = new Book { title = "Book example" };
            Serializer.WriteXML(book);
            Serializer.ReadXML();
        }
    }
}
