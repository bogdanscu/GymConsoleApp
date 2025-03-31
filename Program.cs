using System;
using System.Collections.Generic;
using System.Dynamic;

namespace GymApp
{
    class Program
    {
        static List<Member> members = new List<Member>();
        static void Main(string[] args)
        {



            static void DisplayMenu()
            {
                Console.WriteLine("====== ORADEA GYM MANAGEMENT SYSTEM ======\n");
                Console.WriteLine("1. Add New Member");
                Console.WriteLine("2. View All Members");
                Console.WriteLine("3. Update Member Information");
                Console.WriteLine("4. Delete Member");
                Console.WriteLine("5. Exit");
                Console.WriteLine("==========================================");
                Console.Write("Enter your choice: ");
            }

            int choice;

            do
            {
                DisplayMenu();

                if (!Int32.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalit input! Please choose an option from the menu below");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddMember();
                        break;
                    case 2:
                        ViewMember();
                        break;
                    case 3:
                        UpdateMember();
                        break;
                    case 4:
                        DeleteMember();
                        break;
                    case 5:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine(choice + " is not a valid choice. Please choose an option between 1 and 5!");
                        break;
                }
                //if (choice != 5)
                //{
                //    Console.WriteLine("Invalid choice!");
                //}

            }
            while (choice != 5);
            

        }
        static void AddMember()
        {
            Console.WriteLine("===Add New Member===");
        }

        static void ViewMember()
        {
            Console.WriteLine("=== View Members ===");
        }

        static void UpdateMember()
        {
            Console.WriteLine("=== Update Member ===");
        }

        static void DeleteMember()
        {
            Console.WriteLine("Delete member");
        }

    }


    class Member
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int PhoneNumber { get;set; }
        public string MembershipType { get; set; }
    }
}

