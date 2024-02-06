namespace Work_asiment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter Progect \n 1- Banks \n 2- Student_registration_system");
            int select = int.Parse(Console.ReadLine());
             switch (select)
            {
                case 1:
                    Banks.salary();
                    break;
                    default:
                    Student_registration_system.names();
                    break;
            }
        }
    }
}