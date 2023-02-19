using System;
using System.IO;


namespace New_programs
{
    class student_details
    {
        static void Main(string[] args)
        {
            //string name = "Siva prasad";
            //int rollno = 143;
            //char section = 'A';
            //int number = 63095854;
            //Console.WriteLine(name);
            //Console.WriteLine(rollno);
            //Console.WriteLine(section);
            //Console.WriteLine(number);
            //Console.ReadLine();

            FileInfo f1 = new FileInfo(@"C:\Users\labuser\source\repos\New programs\New programs");
            Console.WriteLine(f1.Name);
            Console.WriteLine(f1.Length);
            Console.WriteLine(f1.CreationTime);
            Console.WriteLine(f1.LastAccessTime);
            Console.WriteLine(f1.LastWriteTime);
            Console.WriteLine(f1.Extension);
            Console.ReadLine();
            
        }
    }
}
