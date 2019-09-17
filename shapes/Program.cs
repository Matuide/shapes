using System;
using System.IO;

namespace shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            string user;
            int points = 0;
            int MAX_points = 0;
            string Continue;
          // bool account;
            bool valid;
            string password;
           
           // Console.WriteLine("Do You have an account");
           // account = Console.ReadLine();
           // if (account = false)
          
            Console.WriteLine("Enter your username:  ");
            user = Console.ReadLine();

            do
            {

                Console.WriteLine("enter your password:  ");
                password = Console.ReadLine();
                valid = PasswordCheck(password);
                if (valid == false)
                {
                    Console.WriteLine(" try again");
                }

            } while (valid == false);

                Console.WriteLine(" good password");

            StreamWriter Location = new StreamWriter(@"G:\New folder\mattneedsafile.csv", true);
            Location.WriteLine(user + "," + password);
            Location.Close();
            
              if(askshape() == "1")
            {
                playtriangle();
            }
        }


        static bool PasswordCheck(string password )
        {
            bool valid = false;
            int passwordlength;
            int uppercase = 0;
            int lowercase = 0;
            int specialdigit = 0;
            passwordlength = password.Length;
            for (int n = 0; n < passwordlength; n++)
            {
                if (password[n] >= 'A' && password[n] <= 'Z')
                {
                    uppercase = uppercase + 1;
                }
                if (password[n] >= 'a' && password[n] <= 'z')
                {
                    lowercase = lowercase + 1;

                }
                if (password[n] >= '!' && password[n] <= '@' || password[n] >= '[' && password[n] <= '`')
                {
                    specialdigit = specialdigit + 1;
                }
            }
            if (lowercase >= 1 && uppercase >= 1 && specialdigit >= 1 && passwordlength >= 8)
            {
                valid = true;
                
            }
            return valid;
        }

        static string askshape()
        {


            string choice;
           // choice.ToString;
            Console.WriteLine("what shape do you want to practice:         " +
               "Press 1 for triangle:      " +
                "press 2 for rectangle:      " +
                "press 3 for circle:      ");
             
            
          choice = Console.ReadLine();

               

            if (choice == "1")
            {

            Console.WriteLine("you picked triangle");
            }
            if (choice == "2")
            {

                Console.WriteLine("you picked rectangle");
            }
            if (choice == "3")
            {

                Console.WriteLine("you picked circle");

            }

            return choice;
        }

        static void playtriangle()
        {
            int points = 0;
            Console.WriteLine("You got {0} points", points);
        }
    }
} 