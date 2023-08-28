using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingSociety {
    class Driver {
        static void Main(string[] args) {
            int choice;

            while (true) {
                Console.WriteLine("\t\tWelcome to Housing Society!");
                for (int i = 0; i < 70; i++) {
                    Console.Write("-");
                }

                Console.Write("\n");

                Console.WriteLine("\n[1] Add a Space");
                Console.WriteLine("[2] List Items");
                Console.WriteLine("[3] Get Statistics");
                Console.WriteLine("[4] Search");
                Console.WriteLine("[5] Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice) {
                    case 1:
                        continue;
                    case 2:
                        continue;
                    case 3:
                        continue;
                    case 4:
                        continue;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("\nInvalid Choice!");
                        continue;
                }

                Console.WriteLine("\nSuccessfully exited the program");
                break;
            }
        }
    }
}