//namespace myapp

//{
//    class Program
//    {
//        static List<string> listname = new List<string>();
//       static void Main()
//        {
//            while (true)
//            {
//                Console.WriteLine("1. Add Student/n 2.Show Student");
//                int userinput = Convert.ToInt32(Console.ReadLine());
//                if (userinput == 1)
//                {
//                    Adddata();
//                }
//                else { }
//                {
//                    showstudent();
//                }
//            } 
//            static void Adddata()
//            {
//                Console.WriteLine("enter name");
//                string name = Console.ReadLine();
//                listname.Add(name);
//            }
//            static void showstudent()
//            {
//                foreach (string names in listname)
//                {
//                    Console.WriteLine($"name is {names}");
//                }
               
//            }

//        } 
//    }
//}

namespace myapp
{
    class program
    {
        static List<Student> listname = new List<Student>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("1. Add Data/n 2.Show Data");

                int userinput = Convert.ToInt32(Console.ReadLine());

                if (userinput == 1) { 
                    Student.Adddata ();
                }
                else
                {
                    Student.showdata();
                }
            }
        }
        class Student { 
        
         public int id { get; set; }
            public string name { get; set; }

            public static void Adddata()
            {
                Student std = new Student();

                Console.WriteLine("enter id");
                std.id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter name");
                std.name = Console.ReadLine();
                listname.Add(std);
            }
            public static void showdata()
            {
                foreach (Student abc in listname)
                {
                    Console.WriteLine($"Id is {abc.id}/n name is {abc.name}");
                }
            }
        }
    }
}