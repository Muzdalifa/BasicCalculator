using System;

namespace Assignment1_BasicCalculator
{
    public class BasicCalculator
    {
        static void Main(string[] args)
        {
            string userChoice;
            do
            {
                Console.Title = "Basic calculator";

                Console.WriteLine("Please select operation you want to perform from the menu below :");

                Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
                Console.WriteLine("¤                 Basic Calculator                  ¤");
                Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");
                Console.WriteLine("¤ 1. Addition                                       ¤");
                Console.WriteLine("¤ 2. Addition(array)                                ¤");
                Console.WriteLine("¤ 3. Substraction                                   ¤");
                Console.WriteLine("¤ 4. Substraction(array)                            ¤");
                Console.WriteLine("¤ 5. Multiplication                                 ¤");
                Console.WriteLine("¤ 6. Division                                       ¤");
                Console.WriteLine("¤ 7. Quit                                           ¤");
                Console.WriteLine("¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤");

                Console.Write("Enter choice : ");
                //userChoice = CheckUserChoice(Console.ReadLine());
                userChoice = Console.ReadLine();

                if (userChoice == "1" || userChoice == "3" || userChoice == "5" || userChoice == "6")
                {
                    SwitchUserChoice(userChoice, GetNumberFromUser("first"), GetNumberFromUser("second"));
                }
                else
                {
                    SwitchUserChoice(userChoice, 0, 0);
                }

            } while (userChoice != "7");
        }

        static public int CheckUserChoice(string userChoice)
        {
            int convertUserChoice = 0;
            try
            {
                convertUserChoice = Convert.ToInt32(userChoice);
            }
            catch (Exception)
            {

                Console.WriteLine("Bad user input");

            }

            return convertUserChoice;
        }

        //Function to get first number from the user
        public static double GetNumberFromUser(string what)
        {
            //set flag to restrict the user to enter only numbers
            bool flag = false;
            double number;
            do
            {
                Console.Write($"Please enter the {what} number : ");
                flag = double.TryParse(Console.ReadLine(), out number);
                if (!flag)
                {
                    Console.WriteLine("The number you enterd is not valid! Please enter valid number.");
                }
            } while (!flag);

            return number;

        }

        // select user choice function
        public static void SwitchUserChoice(string userInput, double firstNumber, double secondNumber)
        {
            //Array to test case 2 and case 4
            double[] arrayNumber = new double[] { -3, 3 };

            switch (userInput)
            {
                case "1":
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {Addition(firstNumber, secondNumber)}");
                    break;
                case "2":
                    Console.Write($"The sum of array [");
                    for (int i = 0; i < arrayNumber.Length; i++)
                    {
                        Console.Write($"{arrayNumber[i]},");
                    }
                    Console.WriteLine($"] = {Addition(arrayNumber)}");
                    break;
                case "3":
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {Substraction(firstNumber, secondNumber)}");
                    break;
                case "4":
                    Console.Write($"The substraction of array [");
                    for (int i = 0; i < arrayNumber.Length; i++)
                    {
                        Console.Write($"{arrayNumber[i]},");
                    }
                    Console.WriteLine($"] = {Substraction(arrayNumber)}");
                    break;
                case "5":
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {Multiplication(firstNumber, secondNumber)}");
                    break;
                case "6":
                    if (secondNumber == 0)
                    {
                        do
                        {
                            Console.WriteLine("You can not divide by zero");
                            secondNumber = GetNumberFromUser("second");
                        } while (secondNumber == 0);
                    }
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {Division(firstNumber, secondNumber)}");
                    break;
                case "7":
                    Console.WriteLine("¤¤¤¤¤¤¤¤¤¤Thank you for using our calcuator¤¤¤¤¤¤¤¤¤¤");
                    break;
                default:
                    Console.WriteLine("You entered the wrong choice! Please enter the value among the given menu");
                    break;
            }
        }


        //Function to add two numbers
        public static double Addition(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        //Function to add two numbers
        public static double Addition(double[] arrayNum)
        {
            double sum = arrayNum[0];
            for (int i = 1; i < arrayNum.Length; i++)
            {
                sum = sum + arrayNum[i];
            }
            return sum;
        }

        //Function to substract two numbers
        public static double Substraction(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        //Function to add two numbers
        public static double Substraction(double[] arrayNum)
        {
            double sum = arrayNum[0];
            for (int i = 1; i < arrayNum.Length; i++)
            {
                sum = sum - arrayNum[i];
            }
            return sum;
        }

        //Function to multiply two numbers
        public static double Multiplication(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        //Function to divide two numbers
        public static double Division(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
            {
                throw new DivideByZeroException("You can not divide by zero.");
            }

            return firstNumber / secondNumber;

        }
    }
}
