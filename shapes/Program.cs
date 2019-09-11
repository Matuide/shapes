﻿using System;

namespace shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            string user;
            bool valid;
            string password;
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
        }
        static bool PasswordCheck(string password ){
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
                if (password[n] >= '!' && password[n] <= '@')
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
}} 
