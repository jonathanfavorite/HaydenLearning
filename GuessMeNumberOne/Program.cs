using System;
using System.Collections.Generic;

namespace GuessMeNumberOne
{

    // Lists of PRO-TIPS
    //  - Double click on any text to see where else it is used in this file (it will highlight them)
    //  - Console.WriteLine() can either show text on the screen (in the console) or if empty, create a new line
    //  - Hold control + mousewheel to increase/decrease the font size

    class Person  // A class is like an 'object', it contains details about whatever you want to put inside
    {
        public string Name; // string is text (like "Jonathan")
        public string LastName = "Favorite"; // string as well, but we default the last name to Favorite, so any new Person will automatically have the last name Favorite
        public string EyeColor; // string again
        public int Age; // int is a solid number (like 1, 2, 3, 4, ect.)
        public double NetWorth; // double means it has a decimal (like 10.01)
        public bool CanByAlcohol = false; // bool means it can be true or false
                                          // We are making it false by default
        // you can add as many different details as your heart desires here!
    }       
    class Program
    {
        static List<Person> myFamily = new List<Person>(); // Remember this (keyword: List<Person>), it's literally a List of Person objects (people)
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Hayden.");
            Console.WriteLine("I want to see if you can understand this code.");
            Console.WriteLine("Try your best to see what it's doing, really look at it.");
            Console.WriteLine("When you're ready to see the final result, press F5 to run it.");
            Console.WriteLine("Don't press f5 until you are look at it.");
            Console.WriteLine("At the very bottom I've added one little test that I want you to fill out.");
            Console.WriteLine();

            // Here we go, these below are functions that perform specific duties, look into each one
            AddPeopleToMyFamily();
            FindOutWhoCanBuyAlcohol();
            WhoCanAffordABoat();
            ShowPeopleBySpecificRequirements();
            ShowTotalNetWorthForFamily();

            // This one is for you, look at it last!
            OnlyShowBlueEyes();

            Console.Read(); // This is just to make sure the program doesn't close on it's own.
        }
        static void AddPeopleToMyFamily()
        {
            Person Alex = new Person();
            Alex.Name = "Alex";
            Alex.Age = 26;
            Alex.NetWorth = 1993.03;
            Alex.EyeColor = "Blue";

            Person Scarlet = new Person();
            Scarlet.Name = "Scarlet";
            Scarlet.Age = 15;
            Scarlet.NetWorth = 83002.27;
            Scarlet.EyeColor = "Red";

            Person Mike = new Person();
            Mike.Name = "Mikey";
            Mike.Age = 35;
            Mike.NetWorth = 45000.03;
            Mike.EyeColor = "Green";

            myFamily.Add(Alex); // Add Alex to the List<Person> named myFamily (see above)
            myFamily.Add(Scarlet); // Add Alex to the List<Person> named myFamily (see above)
            myFamily.Add(Mike); // Add Alex to the List<Person> named myFamily (see above)

            foreach (Person thisPerson in myFamily)
            {
                Console.WriteLine($" - {thisPerson.Name} (Age: {thisPerson.Age}) added to my family.");
            }
            Console.WriteLine();
        }
        static void FindOutWhoCanBuyAlcohol()
        {
            Console.WriteLine("Let's find out who can buy alcohol!");
            int LegalDrinkingAge = 21;

            foreach (Person thisPerson in myFamily)
            {
                if (thisPerson.Age >= LegalDrinkingAge) // >= means greater than or equal to
                {
                    thisPerson.CanByAlcohol = true;
                    Console.WriteLine($" - {thisPerson.Name} can buy alcohol!");
                }
            }
            Console.WriteLine();
        }
        static void WhoCanAffordABoat()
        {
            Console.WriteLine("But who can afford a boat?");
            double boatPrice = 30000.00; // double means there is a decimal (30000.00)
            foreach(Person p in myFamily)
            {
                if(p.NetWorth >= boatPrice)
                {
                    Console.WriteLine($" - {p.Name} can afford to buy a boat!");
                }
            }
            Console.WriteLine();
        }
        static void ShowPeopleBySpecificRequirements()
        {
            int maxAge = 40;
            Console.WriteLine($"Only showing people {maxAge} or younger, and that can drink.");
            foreach (Person p in myFamily)
            {
                if(p.Age <= maxAge) // <= is less than or equal to (so 25 and below)
                {
                    // this person is less than or equal to 25
                    if(p.CanByAlcohol) //    '=' sets the value, '==' compares a value (look at maxAge for reference)
                    {
                        Console.WriteLine($" - {p.Name} ({p.Age} years old.) can drink.");
                    }
                }
            }
            Console.WriteLine();
        }
        static void ShowTotalNetWorthForFamily()
        {
            Console.WriteLine("What is the total net worth of this family?");
            double TotalNetWorth = 0.00;

            foreach(Person p in myFamily)
            {
                TotalNetWorth += p.NetWorth;
            }

            Console.WriteLine($"Total: ${TotalNetWorth}");
            Console.WriteLine();
        }
        static void OnlyShowBlueEyes()
        {
            Console.WriteLine("Who in this family has blue eyes?");
            string chooseThisEyeColor = "Blue";
            foreach(Person p in myFamily)
            {
                /*
                 * This is a big comment. I don't want to give the answer away directly
                 * but I want you to write an IF statement to see who has blue eyes
                 * it will look something like this:
                if (p.EyeColor == ??????)
                {
                    Console.WriteLine($"- {p.Name} has {chooseThisEyeColor} eyes!");
                }
                 * Copy and past the above or re-write it underneath the green comments and test it!
                */
            }
        }
    }

}
