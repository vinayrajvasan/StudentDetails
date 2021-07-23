using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{

    class Program
    {

        static List<Student> stu = new List<Student>();
        static void Main(string[] args)
        {
            print();
            
        }
        static void print()
        {
            int choice = 99;
            while (choice != 0)
            {
                Console.WriteLine("\n\n-------STUDENT MANAGEMENT SYSTEM--------");
                Console.WriteLine("1-VIEW||2-VIEWALL||3-ADD||4-REMOVE||5-UPDATE||6-TOTAL||0-EXIT");
                Console.WriteLine("ENTER THE CHOICE");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                          view();
                        break;
                    case 2:
                        viewall();
                        break;
                    case 3:
                        add();
                        break;
                    case 4:
                        remove();
                        break;
                    case 5:
                        update();
                        break;
                    case 6:
                         total();
                        break;
                    default:
                        Console.WriteLine("CHOOSE A VALID OPTION");
                        break;
                }
            }
        }
        static void view()
        {
            if (stu.Count == 0)
            {
                Console.WriteLine("NO RECORS FOUND");
            }
            else
            {

                Console.WriteLine("ENTER THE ID OF THE STUDENT");
                int sid = Convert.ToInt32(Console.ReadLine());

                var stud = from s in stu where s.id == sid select s;

                
                if (stud.Count() == 0)
                {
                    Console.WriteLine("NO SUCH RECORD FOUND");
                }
                else
                {
                    foreach (Student z in stud)
                    {
                        Console.WriteLine("STUDENT ID:" + z.id + "  STUDENT NAME:" + z.name + "  STUDENT AGE:" + z.age + "  STUDENT PERCENTAGE:" + z.percentage);
                    }
                }
            }
        }
         
        static void viewall()
        {
            if (stu.Count != 0)
            {
                foreach (Student z in stu)
                {
                    Console.WriteLine("STUDENT ID:" + z.id +  "  STUDENT NAME:"+z.name +  "  STUDENT AGE:" + z.age  +"  STUDENT PERCENTAGE:" + z.percentage );
                }
            }
            else
            {
                Console.WriteLine("THERE ARE NO RECORDS");
            }
        }
        static void add()
        {
            //Student stud = new Student(1, "aa", 1 , 1);
            int id;
            String name;
            int age;
            int percentage;

            Console.WriteLine("ENTER THE STUDENT ID");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE STUDENT NAME:");
            name = Console.ReadLine();
            Console.WriteLine("ENTER STUDENT AGE");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER STUDENT PERCENTAGE");
            percentage = Convert.ToInt32(Console.ReadLine());
            stu.Add(new Student(id, name, age, percentage));
        }
        static void remove()
        {
            if (stu.Count == 0)
            {
                Console.WriteLine("NO RECORS FOUND");
            }
            else
            {

                Console.WriteLine("ENTER THE ID OF THE STUDENT");
                int sid = Convert.ToInt32(Console.ReadLine());

                Student value;
                bool deleted = false;
                    for (int i = 0; i < stu.Count; i++)
                    {
                        value = stu[i];
                        // Remove if value is 20.
                        if (value.id==sid)
                        {
                            stu.Remove(value);
                        deleted = true;
                        Console.WriteLine("Delete successful");

                    }
                    }
                if(!deleted)
                {
                    Console.WriteLine("No such record found");
                }
               
                
            }
        }
        
        static void update()
        {
            if (stu.Count == 0)
            {
                Console.WriteLine("NO RECORS FOUND");
            }
            else
            {

                Console.WriteLine("ENTER THE ID OF THE STUDENT");
                int sid = Convert.ToInt32(Console.ReadLine());

                var stud = from s in stu where s.id == sid select s;


                if (stud.Count() == 0)
                {
                    Console.WriteLine("NO SUCH RECORD FOUND");
                }
                else
                {
                    foreach (Student z in stud)
                    {
                        Console.WriteLine(" ENTER THE STUDENT NAME");
                       string name = (Console.ReadLine());
                        Console.WriteLine(" ENTER THE STUDENT AGE");
                       int  age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ENTER THE STUDENT PERCENTAGE");
                       int  percentage = Convert.ToInt32(Console.ReadLine());
                        
                        z.name = name;
                        z.age = age;
                        z.percentage = percentage;
                        Console.WriteLine("UPDATE SUCESSFULL");
                    }
                }

            }
        }
        
       static void total()
        {
            Console.WriteLine("TOTAL NUMBER OF RECORDS IS " + stu.Count);
        }
        


    }
}

