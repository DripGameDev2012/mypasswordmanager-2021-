using System;

namespace program
{
    class program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Welcome to PROGRAM. This is where you can sign up or login! \n(NOTE: You may have to sign up first in order to login.)");
            Console.WriteLine("Would you like to log in or sign up? Type in 'U' to sign up, or type in 'I' to log in.");
            var input1 = Console.ReadLine();
            if (input1 == "u")
            {
                signup();
            }
            if (input1 == "i")
            {
                login();
            }

        }

        public void signup()
        {
            signup(Random.Shared);
        }

        public void signup(Random random)
        {
            Console.WriteLine("Hello there, new user! \nJust to confirm, do you already have an account? Y/N");
            var dude = Console.ReadLine();
            if (dude == "y")
            {
                Console.WriteLine("Transferring to login page...");
                login();
            }
            if (dude == "n")
            {
                Console.WriteLine("Continuing sign up process...");

                int number = random.Next(1000000000, 1000000000);
                int[] recommend = { number, number, number, number, number };

                Console.WriteLine("What do you want your username to be?");
                var username = Console.ReadLine();
                Console.WriteLine($"We recommend your password to be one of the following; {recommend}");
                Console.WriteLine("What do you want your password to be?");
                var password = Console.ReadLine();
                Console.WriteLine($"To move on, please confirm your input. \nYour username is: {username} , and your password is {password} . \nIs this correct? Y/N");
                var yn = Console.ReadLine();
                if (yn == "y")
                {
                    Console.WriteLine("Confirmed. \nYou have created your account!");
                    Console.WriteLine($"WELCOME, {username} !");

                    Console.WriteLine("This program has ended. Please click on any key to exit.");
                    Console.ReadKey();

                    Environment.Exit(0);
                }
                if (yn == "n")
                {
                    Console.WriteLine("Please type in your credentials again.");

                    signup();
                }

            }

        }
        public void login()
        {
            Console.WriteLine("Welcome back, user! \nJust to confirm, you do have an account? Y/N");
            var yeet = Console.ReadLine();
            if (yeet == "n")
            {
                Console.WriteLine("Transferring to signup page...");
                signup();
            }
            if (yeet == "y")
            {
                Console.WriteLine("Continuing login process...");
                Console.WriteLine("Please type in your username and password. (NOTE: THIS IS CASE SENSITIVE)");
                Console.WriteLine("Username: ");
                var yeetus = Console.ReadLine();
                Console.WriteLine("Password: ");
                var yeetusdeletus = Console.ReadLine();
                if (yeetus == username && yeetusdeletus == password)
                {
                    Console.WriteLine("Scanning... \nCorrect username and password.");
                    Console.WriteLine($"Hello, {username}!");
                    Console.WriteLine("This program has ended. Please click on any key to exit.");
                    Console.ReadKey();

                    Environment.Exit(0);

                }
                if (yeetus != username && yeetusdeletus != password)
                {
                    Console.WriteLine("Sorry, but that username or password was incorrect. \nYou will be redirected to the login screen again.");
                    Console.WriteLine("Redirecting...");
                    login();
                }

            }


        }
    }

}