using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_asiment
{
    public static class Student_registration_system
    {
        static Student_registration_system()
        {
            Console.WriteLine("Welcome to the student registration system");

        }

        public static void names()
        {
            while (true)
            {
                Console.WriteLine("Enter the number Select your academic level");
                Console.WriteLine("1-University\n 2-High School\n 3-instiute");

                string x = Console.ReadLine();
                switch (x)
                {
                    case "1":
                        Console.WriteLine("welcom to login University \n How many students do you want to login ");
                        int t = int.Parse(Console.ReadLine());
                        string[] z = new string[t];
                        for (int i = 0; i < t; i++)
                        {
                            Console.WriteLine("write name");
                            string y = Console.ReadLine();

                            z[i] += y;

                        }
                        for (int i = 0; i < t; i++)
                        {
                            Console.WriteLine($" Names student :\n{z[i]}");
                        }
                        break;
                        //case "2":   
                }
                Console.WriteLine("Do you want to change the background color \n yes or No");
                string cv = Console.ReadLine();
                if (cv == "yes")
                {
                    Console.WriteLine("Enter any colors \n red \n Yellow \n green");
                    string aa = Console.ReadLine();
                    switch (aa)
                    {
                        case "red":
                            Colors color1 = (Colors)Enum.Parse(typeof(Colors), aa, true);
                            Console.WriteLine($"{color1} = {(int)color1}");
                            Console.WriteLine(Console.BackgroundColor = ConsoleColor.Red);
                            break;
                        case "yellow":
                            {
                                Colors color2 = (Colors)Enum.Parse(typeof(Colors), aa);
                                Console.WriteLine($"{color2} = {(int)color2}");
                                Console.WriteLine(Console.BackgroundColor = ConsoleColor.Yellow);
                                break;

                            }
                        case "green":
                            {

                                Colors color3 = (Colors)Enum.Parse(typeof(Colors), aa);
                                Console.WriteLine($"{color3} = {(int)color3}");
                                Console.WriteLine(Console.BackgroundColor = ConsoleColor.Green);

                                break;
                            }


                    }

                }
                else
                {
                    //break;
                }

            }




        }
    }
    public enum Colors
    {
        red,
        yellow,
        green,
    }


}
