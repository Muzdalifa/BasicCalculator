using System;

namespace Assignment1_BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            double Num1;
            double Num2;

            do
            {
                Console.WriteLine("Please select operation you want to perform from the menu below :");

                Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
                Console.WriteLine("¤                 Basic Calculator                  ¤");
                Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
                Console.WriteLine("¤ 1. Addition                                       ¤");
                Console.WriteLine("¤ 2. Substraction                                   ¤");
                Console.WriteLine("¤ 3. Multiplication                                 ¤");
                Console.WriteLine("¤ 4. Division                                       ¤");
                Console.WriteLine("¤ 5. Quit                                           ¤");
                Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");

                Console.Write("Enter choice : ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Addition(GetNumberFromUser("first"), GetNumberFromUser("second"));                        
                        break;
                    case "2":
                        Substraction(GetNumberFromUser("first"), GetNumberFromUser("second"));
                        break;
                    case "3":
                        Multiplication(GetNumberFromUser("first"), GetNumberFromUser("second"));
                        break;
                    case "4":
                        Num1 = GetNumberFromUser("first");
                        Num2 = GetNumberFromUser("second");

                        if (Num2 != 0)
                        {
                            Division(Num1, Num2);
                            break;
                        }
                        else
                        {
                            do
                            {
                                Console.WriteLine("No division by 0! Please enter correct number");
                                Num2 = GetNumberFromUser("second");
                            } while (Num2 == 0);
                            
                            Division(Num1, Num2);

                            break;
                        }
                    case "5":
                        Console.WriteLine("¤¤¤¤¤¤¤¤¤¤Thank you for using our calcuator¤¤¤¤¤¤¤¤¤¤");
                        break;
                    default:
                        Console.WriteLine("You enter the wrong choice! Please enter the value among the given menu");
                        break;
                }

            } while (userInput != "5");
        }

        //Function to get first number from the user
        static double GetNumberFromUser(string Number)
        {
            //set flag to restrict the user to enter only numbers
            bool flag = false;
            double Num;
            do
            {
                Console.Write($"Please enter the {Number} number : ");
                flag = double.TryParse(Console.ReadLine(), out Num);
                if(!flag)
                {
                    Console.WriteLine("The number you enterd is not valid! Please enter valid number.");
                }
            } while (!flag);
            
            return Num;                      

        }

        //Function to add two numbers
        static void Addition(double Num1, double Num2)
        {
            Console.WriteLine($"{Num1} + {Num2} = {Num1 + Num2} ");
        }

        //Function to substract two numbers
        static void Substraction(double Num1, double Num2)
        {
            Console.WriteLine($"{Num1} - {Num2} = {Num1 - Num2} ");
        }

        //Function to multiply two numbers
        static void Multiplication(double Num1, double Num2)
        {
            Console.WriteLine($"{Num1} * {Num2} = {Num1 * Num2} ");
        }

        //Function to divide two numbers
        static void Division(double Num1, double Num2)
        {
            Console.WriteLine($"{Num1} / {Num2} = {Num1 / Num2} ");
        }
    }
}
