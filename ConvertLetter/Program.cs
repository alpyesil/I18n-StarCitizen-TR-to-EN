using System;
using System.IO;
using System.Text;

namespace ConvertLetter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            string path = $"{appPath}tr/global.ini"; // ini dosyanızın yolunu belirtin
            string content = File.ReadAllText(path, Encoding.Default);

            content = content.Replace('ş', 's')
                .Replace('Ş', 'S')
                .Replace('ğ', 'g')
                .Replace('Ğ', 'G')
                .Replace('ç', 'c')
                .Replace('Ç', 'C')
                .Replace('ö', 'o')
                .Replace('Ö', 'O')
                .Replace('ü', 'u')
                .Replace('Ü', 'U')
                .Replace('ı', 'i')
                .Replace('İ', 'I');

            if (Directory.Exists(appPath + "en"))
                File.Delete(appPath + "en/global.ini");
            else
                Directory.CreateDirectory(appPath + "en");
            
            path = $"{appPath}en/global.ini";
            File.WriteAllText(path, content, Encoding.Default);
        }
    }
}