using System;
using System.IO;

namespace Get_text
{
    class Program
    {
        static void Main(string[] args)
        {
            string contents = Gettext(@"C:\Users\laksh\Desktop","Emails.txt");
            Console.WriteLine("File contains: \n" + contents);
            Console.ReadKey(true);
        }
        private static string Gettext(string path, string filename)
        {
            var way = File.OpenText(appendpath(path)+filename);
            var text = way.ReadToEnd();
            return text;
            string appendpath(string filepath)
            {
                if (!filepath.EndsWith(@"\"))
                    filepath += @"\";
                return filepath;
            }
        }
    }
}
