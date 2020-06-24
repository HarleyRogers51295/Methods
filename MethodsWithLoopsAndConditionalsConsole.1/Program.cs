using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MethodsWithLoopsAndConditionalsConsole._1
{
    class Program
    {
        static void Main(string[] args)
        {

            NumberList1();//Method 1

            PauseConsole();

            IncThree(); //Method 2

            PauseConsole();

            int userNum1 = GetUserNUmber(); //Method 3 (make methods like this for your other methods!)
            int userNum2 = GetUserNUmber();
            bool areEquil = EquilOrNot(userNum1, userNum2);
            Console.WriteLine($"{userNum1} is equil to {userNum2}: {areEquil}");

            PauseConsole();

            Console.WriteLine("Write your number below");//Method 4
            var num1 = int.Parse(Console.ReadLine());
            EvenOrOdd(num1);

            PauseConsole();

            Console.WriteLine("Write your number below");//Method 5
            var d = int.Parse(Console.ReadLine());
            PosOrNeg(d);

            PauseConsole();

            Console.WriteLine("Write your age below");//Method 6
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))//this is using the TryParse, the while loop will give them another try.
            {
                Console.WriteLine("Could not take value, try again.");
            }
            VoteAge(age); //the Tryparse needs to be used with a non initialized varialble

            PauseConsole();

            int userNumber = GetUserNUmber(); //Method 7
            TenToTen(userNumber);

            PauseConsole();

            int userNumber2 = GetUserNUmber(); //Method 8
            int multiplyTo = GetUserNUmber();
            MultTable(userNumber2, multiplyTo);

            PauseConsole();

            int userNumber1 = GetUserNUmber(); //Method 9
            int[] randoNumbers = ArrayReturn(userNumber1);
            foreach (var number in randoNumbers)
            {
                Console.WriteLine(number);
            }

            PauseConsole();

            int sumOfElements = SumOfArray(randoNumbers);//Method 10
            Console.WriteLine($"The sum of integers in the array = {sumOfElements}");

            PauseConsole();

            int userNumber3 = GetUserNUmber();//Method 11
            CubeOfNum(userNumber3);

        }
        private static int GetUserNUmber()
        {
            Console.Write("Give me a number: ");
            int userNumber = int.Parse(Console.ReadLine());

            return userNumber;
        }
        private static void PauseConsole()
        {
            Console.WriteLine(" ");
            Console.ReadLine();
        }//PauseConsole
        private static void NumberList1()//Method 1 (number 1000 to -1000)
        {
            int goal = -1000;
            for(int i = 1000; i >= goal; i--)
            {
                Console.WriteLine(i);
            }
            //int a = -1001;   (this is how I did it first.)
            //do
            //{
            //    a++;
            //    Console.WriteLine(a);
            //} while (a <= 1000);

            //return a;
        }
        private static void IncThree()//Method 2 (increments of 3 - 999)
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }

            //int plus3 = 0;                    (what i had before)
            //for (int i = 3; i <= 999; i += 3)
            //{
            //    Console.WriteLine(plus3 += 3);
            //}
            //return plus3;
        }
       private static bool EquilOrNot(int num1, int num2)//Method 3 (== or !==)
        {
            return num1 == num2;
            
            //if (a == b)           (I did this..)
            //{
            //    Console.WriteLine("Numbers are Equil.");
            //}
            //else
            //{
            //    Console.WriteLine("Numbers are not Equil.");
            //}   
        }
        private static void EvenOrOdd(int num1)//Method 4 (even or odd)
        {
            if(num1 % 2 == 0)
            {
                Console.WriteLine("number is even.");
            }
            else
            {
                Console.WriteLine("Number is Odd.");
            }
        }
        private static void PosOrNeg(int num1)//Method 5 (positive or Negative)
        {
            
            if( num1 > 0) //Did this one right!
            {
                Console.WriteLine("Number is Positive");
            }
            else
            {
                Console.WriteLine("Number is Negative");
            }

        }
        private static void VoteAge(int userAge)//Method 6 (Vote Age)
        {
            if (userAge > 18) 
            {
                Console.WriteLine("You can vote!");
            }
            else
            {
                Console.WriteLine("You can not vote!");
            }
        }
        private static void TenToTen(int userNumber) //Method 7  (range of numbers)
        {
            if (userNumber >= -10 && userNumber <= 10) //shows that number is between 10 and -10
            {
                Console.WriteLine($"{userNumber} is in range!");
            }
            else
            {
                Console.WriteLine("out of range!");
            }
        }
        private static void MultTable(int userNumber, int multiplyTo) //Method 8 (multiplication table)
        {
            int product = 0;
            for(int i = 0; i <= multiplyTo; i++)
            {
                product = userNumber * i;
                Console.WriteLine($"{userNumber} X {i} = {product}.");
            }
        }
        private static int[] ArrayReturn(int userNumber) //Method 9 (random number array)
        {
            int[] randos = new int[userNumber];
            Random rng = new Random();
            for (int i = 0; i < randos.Length; i++)
            {
                randos[i] = rng.Next(501);
            }
            return randos;
        }
        private static int SumOfArray(int[] randoNumbers) //Method 10
        {
            int sum = 0;

            for(int i = 0; i < randoNumbers.Length; i++)
            {
                sum += randoNumbers[i];
            }
            return sum;
        }
        private static void CubeOfNum(int cubeTo) //Method 11 (this is cubing a number)
        {
            int cubed = 0; //could chasnges the int here to a double and wouldnt have to cast. 

            for(int i = 1; i <= cubeTo; i++)
            {//casting below. changes an double to a int here. This does not have precision.
                cubed = (int)Math.Pow(i, 3);   // could do int cubed = i*i*i;
                Console.WriteLine($"Number is {i} and the cube of {i} is: {cubed}"); //could dp i*i*i
            }
        }

        




    }
}
