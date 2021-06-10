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
                        Num1 = GetFirstNumber();
                        Num2 = GetSecondNumber();
                        Addition(Num1, Num2);                        
                        break;
                    case "2":
                        Num1 = GetFirstNumber();
                        Num2 = GetSecondNumber();
                        Substraction(Num1, Num2);
                        break;
                    case "3":
                        Num1 = GetFirstNumber();
                        Num2 = GetSecondNumber(); 
                        Multiplication(Num1, Num2);
                        break;
                    case "4":
                        Num1 = GetFirstNumber();
                        Num2 = GetSecondNumber();

                        if (Num2 != 0)
                        {
                            Division(Num1, Num2);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("No division by 0");
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
        static double GetFirstNumber()
        {
            double Num1;
            //set flag to restrict the user to enter only numbers
            bool flag = false;
            do
            {
                Console.Write("Please enter the first number : ");
                flag = double.TryParse(Console.ReadLine(), out Num1);
                if(!flag)
                {
                    Console.WriteLine("The number you enterd is not valid! Please enter valid number.");
                }
            } while (!flag);
            
            return Num1;                      

        }

        //Function to get first number from the user
        static double GetSecondNumber()
        {
            double Num2;
            bool flag = false;
            do
            {
                Console.Write("Please enter the second number: ");
                flag = double.TryParse(Console.ReadLine(), out Num2);
                if (!flag)
                {
                    Console.WriteLine("The number you enterd is not valid! Please enter valid number.");
                }
            } while (!flag);
            
            return Num2;                        
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
