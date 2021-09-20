using System;
using System.IO;

namespace GetDocFromBase64
{
    class Program
    {
        static void Main(string[] args)
        {
            string base64BinaryStr = args[1];
            byte[] bytes = Convert.FromBase64String(base64BinaryStr);
            System.IO.FileStream stream = new FileStream(args[0], FileMode.Create);
            System.IO.BinaryWriter writer = new BinaryWriter(stream);
            writer.Write(bytes, 0, bytes.Length);
            writer.Close();
            Console.WriteLine("Document Created at " + args[0]);
        }
    }
}
