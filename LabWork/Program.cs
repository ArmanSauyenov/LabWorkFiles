using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Программным путем:
//1.	В папке С:\temp создайте папки К1 и К2.
//2.	В папке К1:
//1.	создайте файл t1.txt, в который запишите следующий текст :
//Иванов Иван Иванович, 1965 года рождения, место жительства г.Саратов
//2.	создайте файл t2.txt, в который запишите следующий текст:
//Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс
//3.	В папке К2 создайте файл t3.txt, в который перепишите вначале текст из файла t1.txt, а затем из t2.txt
//4.	Выведите развернутую информацию о созданных файлах.
//5.	Файл t2.txt перенесите в папку K2.
//6.	Файл t1.txt скопируйте в папку K2.
//7.	Папку K2 переименуйте в ALL, а папку K1 удалите.
//8.	Вывести полную информацию о файлах папки All.



namespace LabWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.	В папке С:\temp создайте папки К1 и К2.
            string path = @"C:/temp";

            DirectoryInfo di = new DirectoryInfo(path);
            di.CreateSubdirectory(@"K1");
            di.CreateSubdirectory(@"K2");

            //2.	В папке К1:
            //1.	создайте файл t1.txt, в который запишите следующий текст :
            //Иванов Иван Иванович, 1965 года рождения, место жительства г.Саратов
            FileInfo fi = new FileInfo(@"C:/temp/K1/t1.txt");
            if(!fi.Exists)
            { 
                using (StreamWriter sr = new StreamWriter(@"C:/temp/K1/t1.txt"))
                    sr.Write("Иванов Иван Иванович, 1965 года рождения, место жительства г.Саратов");
            }
            //2.	создайте файл t2.txt, в который запишите следующий текст:
            //Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс
            FileInfo fi2 = new FileInfo(@"C:/temp/K1/t2.txt");
            if (!fi2.Exists)
            {
                using (StreamWriter sr = new StreamWriter(@"C:/temp/K1/t2.txt"))
                    sr.Write("Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
            }
            //3.	В папке К2 создайте файл t3.txt, в который перепишите вначале текст из файла t1.txt, а затем из t2.txt
            fi.CopyTo(@"C:/temp/K2/t3.txt");
            if (fi.Exists)
            {
                using (StreamWriter writer = new System.IO.StreamWriter(@"C:/temp/K2/t3.txt", true))
                {
                    writer.WriteLine();
                    writer.WriteLine("Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
                }
            }
        }
    }
}
