using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;

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
                        Console.WriteLine($"{choice} is not a valid choice. Please choose an option between 1 and 5!");
                        break;
                }
            }
            while (choice != 5);
            

        }
        static void AddMember()
        {
            Console.Clear();
            Console.WriteLine("===Add New Member===\n");

            Console.Write("Enter member id: ");
            int memberID;
            while (!Int32.TryParse(Console.ReadLine(), out memberID))
            {
                Console.WriteLine("Invalit input. Please enter a number!");
            }

            bool idExists = members.Exists(m => m.ID == memberID);
            if (idExists)
            {
                Console.WriteLine("A member with this ID already exists!");
                return;
            }
            //bool idExists = false;
            //foreach (var m in members)
            //{
            //    if (m.ID == memberID)
            //    {
            //        idExists = true;
            //        break;
            //    }
            //}



            Console.Write("Enter name: ");
            string memberName = Console.ReadLine();

            Console.Write("Enter age: ");
            int memberAge;
            while (!Int32.TryParse(Console.ReadLine(), out memberAge))
            {
                Console.WriteLine("Invalit input. Please enter a number!");
            }



            Console.Write("Enter membership type  (montlhy/yearly): ");
            string membershipType = Console.ReadLine();

            Member newMember = new Member
            {
                ID = memberID,
                Name = memberName,
                Age = memberAge,
                MembershipType = membershipType
            };

            members.Add(newMember);
            Console.WriteLine("Member added!");

            Console.ReadKey();
        }

        static void ViewMember()
        {
            Console.Clear();
            Console.WriteLine("=== View Members ===");

            if (members.Count == 0)
            {
                Console.WriteLine("No members found!");
                return;
            }
            foreach (Member m in members)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine($"ID: {m.ID} ");
                Console.WriteLine($"Name: {m.Name} ");
                Console.WriteLine($"Age: {m.Age} ");
                Console.WriteLine($"Membership: {m.MembershipType} ");
            }
            Console.WriteLine("-----------------");
            Console.ReadKey();
        }

        static void UpdateMember()
        {
            Console.Clear();
            Console.WriteLine("=== Update Member ===");
            Console.WriteLine("-----------------");
            Console.Write("Enter member id to update: ");
            int memberID;
            while (!Int32.TryParse(Console.ReadLine(), out memberID))
            {
                Console.WriteLine("Invalit input. Please enter a number!");
            }
            Member memberToUpdate = members.Find(m => m.ID == memberID);
            if (memberToUpdate == null)
            {
                Console.WriteLine("Member not found.");
                return;
            }


        }

        static void DeleteMember()
        {
            Console.Clear();
            Console.WriteLine("Delete member");
        }

    }


    class Member
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string MembershipType { get; set; }
    }
}

