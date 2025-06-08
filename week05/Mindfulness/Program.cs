using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Menu Options:");
        // Console.WriteLine("1. Start breathing activity");
        // Console.WriteLine("2. Start reflecting activity");
        // Console.WriteLine("3. Start listing activity");
        // Console.WriteLine("4. Quit");
        // Console.Write("Select a choice from the menu: ");
        while (true)
        {
            Console.Clear();
            Console.WriteLine("-- Mindfulness Program --");
            Console.WriteLine(" Menu Options:");
            Console.WriteLine();
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Clear();
                Breathing breathing = new Breathing("Breathing Activity",
                "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing", 0);
                breathing.DisplayStartingMessage();
                breathing.Run();
                breathing.DisplayEndingMessage();
            }
            else if (choice == "2")
            {
                Console.Clear();
                Reflecting reflecting = new Reflecting("Reflection Activity",
                "This activity will help you reflect on times in your life when you have shown strength and resilience.", 0);
                reflecting.DisplayStartingMessage();
                reflecting.Run();
                reflecting.DisplayEndingMessage();
            }
            else if (choice == "3")
            {
                Console.Clear();
                Listing listing = new Listing("Listing Activity",
                "This activity will help you reflect on the good things in your life by having you list as many things as you can.", 0);
                listing.DisplayStartingMessage();
                listing.Run();
                listing.DisplayEndingMessage();
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press enter to try again.");
                Console.ReadLine();
            }

        }
    }

}