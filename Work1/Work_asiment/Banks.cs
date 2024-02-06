namespace Work_asiment
{
    public static class Banks
    {
        public static int Password()
        {
            var rnd = new Random();
            var value = rnd.Next(1000, 9999);
            Console.WriteLine($"is password or Random it = {value}");
            return value;

        }
        static Banks()
        {
            Console.WriteLine("Welcome to Turkish Exchange");
        }
        public static void salary()
        {
            Console.WriteLine("1-Enter the password");
            Console.WriteLine("2-Exit");
            int pass = int.Parse(Console.ReadLine());
            switch (pass)
            {
                case 1:
                    {
                        Console.WriteLine("Write password");
                        int pass1 = int.Parse(Console.ReadLine());
                        if (pass1 == 123456789)
                        {
                            while (true)
                            {
                                Console.WriteLine("1- Cach withdrawal");
                                Console.WriteLine("2- Deposit Money");
                                Console.WriteLine("3-  Pay bill");
                                Console.WriteLine("4-  exist");
                                string x = Console.ReadLine();

                                switch (x)
                                {
                                    case "1":
                                        Console.WriteLine("Enter the amount you want to withdraw");
                                        int y = int.Parse(Console.ReadLine());
                                      if (y==0)
                                        {
                                            Console.WriteLine("Can not enter Zero");    
                                        }
                                      else if (y<0)
                                        {
                                            Console.WriteLine("can not enter number negtive ");
                                        }
                                        else
                                        {
                                            Console.WriteLine($"An amount has been withdrawn ={y}");
                                            //break;
                                        }
                                        break;
                                        
                                    case "2":
                                        Console.WriteLine($"Enter the account nymber you are depositing to");
                                        int f = int.Parse(Console.ReadLine());
                                        Console.WriteLine("How much");
                                        int fb = int.Parse(Console.ReadLine());
                                        Console.WriteLine($"namber of account{f}\n much of mony= {fb}");
                                        break;
                                    case "3":
                                        Console.WriteLine("Choose any invoice you want\n 1- Enternt \n 2-water \n 3-electricity");
                                        string l = Console.ReadLine();
                                        switch (l)
                                        {
                                            case "1":
                                                Console.WriteLine("Enter the numbr your enterint");
                                                int n = int.Parse(Console.ReadLine());
                                                Console.WriteLine("hoe much do you want pay");
                                                Console.WriteLine("Enter the numbr your enterint");
                                                int o = int.Parse(Console.ReadLine());
                                                Console.WriteLine($"Opertion accomplished successfully\n your nymber ={n} and yor  mony={o} ");
                                                break;
                                            case "2":
                                                Console.WriteLine("Enter the numbr your water");
                                                int p = int.Parse(Console.ReadLine());
                                                Console.WriteLine("hoe much do you want pay");
                                                Console.WriteLine("Enter the numbr your of pay bill");
                                                int pp = int.Parse(Console.ReadLine());
                                                Console.WriteLine($"Opertion accomplished successfully\n your nymber ={p} and yor  mony={pp} ");
                                                break;
                                            default:
                                                Console.WriteLine("thank you mr. mohmed bn zooa");
                                                break;

                                        }
                                        break;

                                }



                            }
                        }
                        else if (pass1 != 123456789)
                        {
                            Console.WriteLine("password is wrong");

                            Console.WriteLine(" Do you want send a new password\n Yes or No");
                            string Bb_pass = Console.ReadLine();
                            switch (Bb_pass)
                            {
                                case "yes":
                                    int v = Password();

                                    Console.WriteLine("enter new pass");
                                    int pp = int.Parse(Console.ReadLine());
                                    if (v == pp)
                                    {
                                        Console.WriteLine("1- Cach withdrawal");
                                        Console.WriteLine("2- Deposit Money");
                                        Console.WriteLine("3-  Pay bill");
                                        Console.WriteLine("4-  exist");
                                        string xx = Console.ReadLine();
                                        switch (xx)
                                        {
                                            case "1":
                                                Console.WriteLine("Enter the amount you want to withdraw");
                                                int y = int.Parse(Console.ReadLine());
                                                Console.WriteLine($"An amount has been withdrawn ={y}");
                                                break;
                                            case "2":
                                                Console.WriteLine($"Enter the account nymber you are depositing to");
                                                int f = int.Parse(Console.ReadLine());
                                                Console.WriteLine("How much");
                                                int fb = int.Parse(Console.ReadLine());
                                                Console.WriteLine($"namber of account{f}\n much of mony= {fb}");
                                                break;
                                            case "3":
                                                Console.WriteLine("Choose any invoice you want\n 1- Enternt \n 2-water \n 3-electricity");
                                                string l = Console.ReadLine();
                                                switch (l)
                                                {
                                                    case "1":
                                                        Console.WriteLine("Enter the numbr your enterint");
                                                        int n = int.Parse(Console.ReadLine());
                                                        Console.WriteLine("hoe much do you want pay");
                                                        Console.WriteLine("Enter the numbr your enterint");
                                                        int o = int.Parse(Console.ReadLine());
                                                        Console.WriteLine($"Opertion accomplished successfully\n your nymber ={n} and yor  mony={o} ");
                                                        break;
                                                    case "2":
                                                        Console.WriteLine("Enter the numbr your water");
                                                        int p = int.Parse(Console.ReadLine());
                                                        Console.WriteLine("hoe much do you want pay");
                                                        Console.WriteLine("Enter the numbr your of pay bill");
                                                        int ppm = int.Parse(Console.ReadLine());
                                                        Console.WriteLine($"Opertion accomplished successfully\n your nymber ={p} and yor  mony={ppm} ");
                                                        break;
                                                    default:
                                                        Console.WriteLine("thank you mr. mohmed bn zooa");
                                                        break;

                                                }
                                                break;

                                        }


                                    }
                                    break;
                            }
                            //Password();
                        }
                        break;

                    }
                default:
                    break;
                
            }
            //while (true)
            //{
            //    Console.WriteLine("1- Cach withdrawal");
            //    Console.WriteLine("2- Deposit Money");
            //    Console.WriteLine("3-  Pay bill");
            //    Console.WriteLine("4-  exist");
            //    string x = Console.ReadLine();

            //    switch (x)
            //    {
            //        case "1":
            //            Console.WriteLine("Enter the amount you want to withdraw");
            //            int y = int.Parse(Console.ReadLine());
            //            Console.WriteLine($"An amount has been withdrawn ={y}");
            //            break;
            //        case "2":
            //            Console.WriteLine($"Enter the account nymber you are depositing to");
            //            int f = int.Parse(Console.ReadLine());
            //            Console.WriteLine("How much");
            //            int fb = int.Parse(Console.ReadLine());
            //            Console.WriteLine($"namber of account{f}\n much of mony= {fb}");
            //            break;
            //        case "3":
            //            Console.WriteLine("Choose any invoice you want\n 1- Enternt \n 2-water \n 3-electricity");
            //            string l = Console.ReadLine();
            //            switch (l)
            //            {
            //                case "1":
            //                    Console.WriteLine("Enter the numbr your enterint");
            //                    int n = int.Parse(Console.ReadLine());
            //                    Console.WriteLine("hoe much do you want pay");
            //                    Console.WriteLine("Enter the numbr your enterint");
            //                    int o = int.Parse(Console.ReadLine());
            //                    Console.WriteLine($"Opertion accomplished successfully\n your nymber ={n} and yor  mony={o} ");
            //                    break;
            //                case "2":
            //                    Console.WriteLine("Enter the numbr your water");
            //                    int p = int.Parse(Console.ReadLine());
            //                    Console.WriteLine("hoe much do you want pay");
            //                    Console.WriteLine("Enter the numbr your of pay bill");
            //                    int pp = int.Parse(Console.ReadLine());
            //                    Console.WriteLine($"Opertion accomplished successfully\n your nymber ={p} and yor  mony={pp} ");
            //                    break;
            //                default:
            //                    Console.WriteLine("thank you mr. mohmed bn zooa");
            //                    break;

            //            }
            //            break;
            //    }


            //}
        }
    }
}