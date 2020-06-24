using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace MethodsWithLoopsAndConditionalsConsole._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Overloading Exersise
            Console.Write("Enter your number: ");
            int num4 = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            int num5 = int.Parse(Console.ReadLine());
            Console.WriteLine(Add(num4, num5));

            Console.Write("Enter your number with decimals: ");
            double num6 = double.Parse(Console.ReadLine());
            Console.Write("Enter your second number with decimals: ");
            double num7 = double.Parse(Console.ReadLine());
            Console.WriteLine(Add(num6, num7));


            Console.Write("enter your number: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("enter your second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Do you want an answer? Write true or false: ");
            bool isTrue =bool.Parse(Console.ReadLine());
            Console.WriteLine(Add(num3, num2, isTrue));

            PauseConsole();
            //examples of overlaoding
            var numberFromMethod = Same(1, 15.0);//using double
            var numberFromMethod1 = Same(1, 15, 13);//using the three one
            var numberFromMethod2 = Same(1, 15);//using the two one
            Console.WriteLine(numberFromMethod);
            Console.WriteLine(numberFromMethod1);
            Console.WriteLine(numberFromMethod2);

            PauseConsole();
            //write for loop 15 times.
            for(int a = 0; a < 1; a++)
            {
                Console.WriteLine($"{a}");
            }
            for (int b = 0; b < 2; b++)
            {
                Console.WriteLine($"{b}");
            }
            for(int c =0; c < 3; c++)
            {
                Console.WriteLine($"{c}");
            }
            for(int s = 0; s < 4; s++)
            {
                Console.WriteLine($"{s}");
            }
            for(int e = 0; e < 5; e++)
            {
                Console.WriteLine($"{e}");
            }
            for(int f = 0; f < 6; f++)
            {
                Console.WriteLine($"{f}");
            }
            for(int g = 0; g < 7; g++)
            {
                Console.WriteLine($"{g}");
            }
            for(int h = 0; h < 8; h++)
            {
                Console.WriteLine($"{h}");
            }
            for(int i = 0; i < 9; i++)
            {
                Console.WriteLine($"Your numbers are{i}.");
            }
            for(int l = 0; l < 10; l++)
            {
                Console.WriteLine($"{l}");
            }
            for(int m = 0; m < 11; m++)
            {
                Console.WriteLine($"{m}");
            }
            for(int n = 0; n < 12; n++)
            {
                Console.WriteLine($"{n}");
            }
            for(int o = 0; o < 13; o++)
            {
                Console.WriteLine($"{o}");
            }
            for(int p = 0; p < 14; p++)
            {
                Console.WriteLine($"{p}");
            }
            for(int q = 0; q < 15; q++)
            {
                Console.WriteLine($"{q}, this is the last for loop");
            }
            PauseConsole();
            int r = 0;
            while(r < 1){
                r++;
                Console.WriteLine($"{r}, this is the first while loop");
            }
            int t = 0;
            while(t < 2)
            {
                t++;
                Console.WriteLine($"{t}");
            }
            int u = 0;
            while(u < 3)
            {
                u++;
                Console.WriteLine($"{u}");
            }
            int v = 0;
            while (v < 4)
            {
                v++;
                Console.WriteLine($"{v}");
            }
            int w = 0;
            while (w < 5)
            {
                w++;
                Console.WriteLine($"{w}");
            }
            int x = 0;
            while(x < 6)
            {
                x++;
                Console.WriteLine($"{x}");
            }
            int y = 0;
            while(y < 7)
            {
                y++;
                Console.WriteLine($"{y}");
            }
            int z = 0;
            while(z < 8)
            {
                z++;
                Console.WriteLine($"{z}, This is the last while loop.");
            }
            PauseConsole();
            int aa = 0;
            do
            {
                aa++;
                Console.WriteLine($"{aa}, this is the begening of the do-while's");
            } while (aa < 5);
            int ab = 0;
            do
            {
                ab++;
                Console.WriteLine($"{ab}");
            } while (ab < 5);
            int ac = 0;
            do
            {
                ac++;
                Console.WriteLine($"{ac}");
            } while (ac < 5);
            PauseConsole();
            int[] numbers1 = { 1, 2, 3, 4, 5, 6 };
            foreach(int number in numbers1)
            {
                Console.WriteLine($"{number}, this is the beginning of the foreach loops");
            }
            List<int> newList = new List<int>() { 2, 3, 4, 5 };//this is wrong btw!(fix after lists lessons!
            foreach(int number in newList)//this is wrong btw!
            {
                Console.WriteLine($"{newList}");
            }



            PauseConsole();
            //This is a giant list of Methods!

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
            int[] randoNumbers = ArrayReturn(userNumber1);//could use var instead of int[]
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

        }//the Methods start here! (1-6)
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
        
        //More difficult method exersises.(7-11)
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
            //create an array
            int[] randos = new int[userNumber];
            //create a random object
            Random rng = new Random();
            //loop through our array
            for (int i = 0; i < randos.Length; i++)
            {
               //assign each index a random int value
                randos[i] = rng.Next(501);
            }

            int randoNum = rng.Next(randos.Length + 1);//to select a random number the array
            Console.WriteLine($"your damage delt is {randos[randoNum]}");

            
            //return the array
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
        
        
        //Overloading Examples
        private static int Same(int a, int b)//example of overlaoding
        {
            return a + b;
        }
        private static double Same(double a, double b) // you have to change all the data types to overload.
        {
            return a + b;
        }
        /*private static double Same(int a, int b)//this would not work.
        {
            return a + b;
        }*/
        private static int Same(int a, int b, int c)//adding the c makes it vallid. 
        {
            return a + b + c;
        }
        // end of the example of overlaoding.

       
       //overloading Exersise. 
        private static int Add(int a, int b)
        {
            return a + b;
        }
        private static double Add(double a, double b)
        {
            return a + b;
        }
        private static string Add(int a, int b, bool isTrue)//to do bools and ints use a string!
        {


            if (isTrue == true)
            {
                int answer = a + b;
                if (answer > 1)
                {
                    return $"{answer} dollars!";

                }
                else
                {
                    return $"{answer} dollar!";
                }
            }
            else
            {
                return "No Answer";
            }

        }
    }
}
