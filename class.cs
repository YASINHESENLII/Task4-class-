// Student classi yaradirsiz. 
// Name, Surname, Group, Point, isGraduated(mezun olub olmadigi ile bagli boolean bir type olacaq)
//  field-leri olacaq.Student classindan instance alindigi zaman isGraduated-den bashqa bütün dəyərləri ötürülməlidir.
// isGraduated constructorişə düşdükdə gelen Point field-nə əsasən təyin olunmalıdır(65-den aşagidirsa kesilib).
// Student classinda aşağıdakı methodlari yazırsız:



//     a)Getİnfo() - Studentin butun deyerlerini consola cixardan bir method.
using System.Dynamic;
namespace TAsk5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.name = "Yasin";
            student.surname = "Hesenli";
            student.Point = 100;
            student.isGRaudated = true;
            student.Getinfo();
        }
    }
     class Student
    {
        
        public string name;
        public string surname;
        public string Group;
        public int Point;
        public bool isGRaudated;

        public void  Getinfo()
        {
            Console.WriteLine($"Name:{name} Surname:{surname} Group:{Group} Point:{Point} Graudated:{isGRaudated}");

        }

    }
}








//b)CheckGraduation() - Student-in mezun olub olmadigini(isGraduated-fieldine esasen) ekrana cixaran method. 
//Eger mezun olubsa bu telebe mezun olub deye yazilsin, eger mezun olmayibsa mezun olmadigi ile bagli bir melumat yazilsin.



using System.Drawing;
using System.Dynamic;
using System.Xml.Linq;

namespace TAsk5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(100);
            student.CheckGraduation();



        }
    }
    class Student
    {

        public int Point;
        public bool Isgraduated;


        public Student(int point )
        {


            Point = point;
            Isgraduated = point > 65;
        }

        public void CheckGraduation()
        {



            if (Isgraduated)
            {
                Console.WriteLine("Mezun Olduz");

            }
            else
            {
                Console.WriteLine("Mezun Olmadiniz");


            }
        }

    }
}







// c)GetDiplomDegree() - Studentin Point-nə əsasən diplom növünü ekrana çıxaran method.
// Eger 65-den kicikdirse yoxdur, 65-80 araligindadirsa adi, 80-90 araligindadirsa şərəf, 90-dan yuxaridirsa yüksək şərəf.

using System.Drawing;
using System.Dynamic;
using System.Xml.Linq;

namespace TAsk5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(100);
            student.CheckGraduation();



        }
    }
    class Student
    {

        public int Point;
        public bool Isgraduated;


        public Student(int point)
        {


            Point = point;
            
        }

        public void CheckGraduation()
        {
            

            if (Point<=65)
            {
                Console.WriteLine("Diplom yoxdur");

            }
            else if(Point<=80&&Point>65)
            {
                Console.WriteLine("Adi diplom");


            }
            else if (Point>80&&Point<=90)
            {
                Console.WriteLine("sərəf diplomu");
            }
            else if (Point > 90 && Point <=100)
            {
                Console.WriteLine(" Yuksek seref diplomu");
            }
        }

    }
}