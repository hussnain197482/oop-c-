using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();

            while (true)


            {
                int choice = loginmenu();
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("enter name");
                        string name = Console.ReadLine();
                        Console.WriteLine("enter password");
                        string password = Console.ReadLine();
                        Console.WriteLine("enter role");
                        string role = Console.ReadLine();
                        User u1 = new User(name, password, role);
                       Console.WriteLine( u1.adduser(u1));
                        break;
                    case 2:
                        Console.WriteLine("enter name");
                        string names = Console.ReadLine();
                        Console.WriteLine("enter password");
                        string passwords = Console.ReadLine();
                        User existinguser = User.validateuser(names, passwords);
                        if (existinguser.roles == "admin")
                        {
                            while (true)
                            {
                                Console.Clear();
                                int choices = adminmenu();
                                switch (choices)
                                {
                                    case 1:
                                        Console.WriteLine("enter car name");
                                        string carname = Console.ReadLine();
                                        Console.WriteLine("Enter car rate");
                                        float rate = float.Parse(Console.ReadLine());
                                        Console.WriteLine("enter car color");
                                        string color = Console.ReadLine();
                                        Console.WriteLine("Enter car model");
                                        string model = Console.ReadLine();
                                        car c1 = new car(carname, rate, color, model);
                                        Console.WriteLine(car.addcar(c1));
                                        break;
                                    case 2:
                                        car.ShowCars();
                                        break;
                                    case 3:
                                        Console.WriteLine("enter carname to update");
                                        string car_name = Console.ReadLine();
                                        Console.WriteLine("enter new carname");
                                        string newcarname = Console.ReadLine();
                                        Console.WriteLine("enter new rate");
                                        float newrate = float.Parse(Console.ReadLine());
                                        Console.WriteLine("enter new color");
                                        string newcolor = Console.ReadLine();
                                        Console.WriteLine(car.updatecar(car_name, newcarname, newrate, newcolor));
                                        break;
                                    case 4:
                                        Console.WriteLine("enter carname to delete");
                                        string dcar = Console.ReadLine();
                                        Console.WriteLine(car.DeleteCar(dcar));
                                        break;
                                    case 5:
                                        car.sortcar();
                                        break;

                                        

                                }
                                break;
                                
                                
                               
                                    Console.ReadKey();
                                Console.Clear();

                            }

                        }
                        break;

                }
            }

        }
        static int loginmenu()
        {
            Console.WriteLine("_____________LOGIN MENU _________________");
                Console.WriteLine("1:sign up");
            Console.WriteLine("2:sign in");
            Console.WriteLine("3:exit");
            int option = int.Parse(Console.ReadLine());
            return option;


        }
        static int adminmenu()
        {
            Console.WriteLine("_____________Admin Menu_________________");
            Console.WriteLine("1:Add a car");
            Console.WriteLine("1:Show cars");
            Console.WriteLine("3:Update car data");
            Console.WriteLine("4:Delete a car");
            Console.WriteLine("5:Sort cars by rate");
            Console.WriteLine("5:Exit");
            int option = int.Parse(Console.ReadLine());
            return option;


        }
        static int UserMenu()

        {
            Console.WriteLine("_____________User Menu_________________");
            Console.WriteLine("1:Show cars");
            Console.WriteLine("2:Search a car");
            Console.WriteLine("3:rent a car");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
