using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_set_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Qset2_1();
        }
        static void Qset2_1()
        {
            Console.WriteLine("Find the number is positive or negative or zero");
            int a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("zero");
            }
            else if (a >= 0)
            {
                Console.WriteLine("positive");
            }
            else if (a < 0)
            {
                Console.WriteLine("negative");
            }
        }

        static void Qset2_2()
        {
             
            int a = 10;
            int b = 10;
            if (a == b)
            {
                Console.WriteLine("a is equal to b");
            }
            else
            {
                Console.WriteLine("a is not equal to b");
            }
        }

        static void Qset2_3()
        {
            double a = 0.3;
            double b = 0.2 + 0.1;
            double tolerance = 0.001;
            if (Math.Abs(a - b) < tolerance)
            {
                Console.WriteLine("equal");
            }
            if (a == b)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
        }

        static void Qset2_4()
        {
            Console.WriteLine("Find the number is Odd or Even");

            Console.WriteLine(" Enter the number");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("The Number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
        static void Qset2_5()
        {
            Console.WriteLine("Find the leap year or non Leap Year");

            Console.WriteLine("Enter the year");


            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("The year is:" + year);

            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("It is a leap year");
            }
            else
            {
                Console.WriteLine("It is a non leap year");
            }
        }
        static void Qset2_6()
        {
            Console.WriteLine("Find the Candidate is elgible for vote or not");


            Console.WriteLine("Enter the age:");

            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("The age is:" + age);

            if (age >= 18)
            {
                Console.WriteLine("Eligible for vote");
            }
            else if (age < 18)
            {
                Console.WriteLine("It is a child");
            }
            else
            {
                Console.WriteLine("not eligible for vote");
            }
        }
        static void Qset2_7()
        {
            Console.WriteLine("Find the person height");


            Console.WriteLine("Enter the height");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("The height is: " + height);
            if (height > 7.5 && height <= 8.0)
            {
                Console.WriteLine("Tallest Person");
            }
            else if (height > 6.5 && height <= 7.5)
            {
                Console.WriteLine("Medium person");
            }
            else if (height > 0 && height <= 6.5)
            {
                Console.WriteLine("shortest person");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
        static void Qset2_8()
        {
             Console.WriteLine("Find the largest among three numbers:");

            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("The p value is:" + p);
            int q = int.Parse(Console.ReadLine());
            Console.WriteLine("The q value is:" + q);
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("The r value is:" + r);

            //Type 1....
            /* {
                 if(p>q && p>r)
                 {
                     Console.WriteLine("p is a biggest");
                 }

                 else if(q>r && q>p)

                 {
                     Console.WriteLine("q is a biggest");
                 }
                 else 
                 {
                     Console.WriteLine("r is a biggest");
                 }
             }*/

            //type 2...
            int biggest = p;
            if (q > biggest)
            {
                biggest = q;
            }
            if (r > biggest)
            {
                biggest = r;
            }
            Console.WriteLine(" The biggest no is" + biggest);
        
    
        }
        static void Qset2_9()
        {
            Console.WriteLine("find the smallest among three numbers");


            Console.WriteLine("Enter the first number");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("The first number is:" + l);

            Console.WriteLine("Enter the second number");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("The second number is :" + m);

            Console.WriteLine("Enter the third number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The third number is :" + n);

            //TYPE 1...
            /*
                        if (l < m)
                            if (l < n)
                            {
                                Console.WriteLine("first is a smallest:");
                            }
                            else
                            {
                                Console.WriteLine(" third is a smallest");
                            }
                        else
                        {
                            if (m < n)
                            {
                                Console.WriteLine("second is a smallest");
                            }
                            else
                            {
                                Console.WriteLine("third is a smallest");
                            }

                        }*/

            //TYPE 2...
            int smallest = l;
            if (m < smallest)
            {
                m = smallest;
            }
            if (n < smallest)
            {
                n = smallest;
            }
        }
        static void Qset2_10()
        {
            {
                Console.WriteLine("Find the largest among four numbers");

                Console.WriteLine("Enter the first number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("The First number is" + num1);

                Console.WriteLine("Enter the Second number");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("The Second number is" + num2);

                Console.WriteLine("Enter the third number");
                int num3 = int.Parse(Console.ReadLine());
                Console.WriteLine("The third number is" + num3);

                Console.WriteLine("Enter the fourth number");
                int num4 = int.Parse(Console.ReadLine());
                Console.WriteLine("The fourth number is" + num4);

                if (num1 > num2 && num1 > num3 && num1 > num4)
                {

                    Console.WriteLine("first number is biggest");
                    //return num1;
                }
                else if (num2 > num3 && num2 > num4 && num2 > num1)
                {
                    Console.WriteLine("Second number is biggest");
                    //return num2;
                }
                else if (num3 > num4 && num3 > num1 && num3 > num2)
                {
                    Console.WriteLine("Third number is biggest");
                    //return num3;
                }
                else
                {
                    Console.WriteLine("Fourth number is biggest");
                    //return num4;

                }
            }
        }
        static void Qset2_11()
        {
            Console.WriteLine("Find the numbers that are closer to each other:");

            Console.WriteLine("Enter the number one");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("The number one is" + num1);

            Console.WriteLine("Enter the number two");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The number two is" + num2);

            Console.WriteLine("Enter the number three");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("The number three is" + num3);

            int p = Math.Abs(num1 - num2);
            Console.WriteLine("The p value is " + p);
            int q = Math.Abs(num2 - num3);
            Console.WriteLine("The q value is " + q);
            int r = Math.Abs(num3 - num1);
            Console.WriteLine("The r value is " + r);


            if (p < q && p < r)
            {
                Console.WriteLine("one and three numbers are closer to each other");
            }

            if (q < r && q < p)
            {
                Console.WriteLine("two and three numbers are closer to each other");
            }
            if (r < q && r < p)
            {
                Console.WriteLine("Two  and one numbers are closer to each other");
            }
            else 
             {
                Console.WriteLine(" not equal to each other");
             }
        }
        static void Qset2_12()
        {
            Console.WriteLine("Find the numbers that are farther from each other:");

            Console.WriteLine("Enter the number one");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("The number one is" + num1);

            Console.WriteLine("Enter the number two");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("The number two is" + num2);

            Console.WriteLine("Enter the number three");
            double num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("The number three is" + num3);

            double p = (num1 / num2);
            Console.WriteLine("The p value is " + p);
            double q = (num2 / num3);
            Console.WriteLine("The q value is " + q);
            double r = (num3 / num1);
            Console.WriteLine("The r value is " + r);


            if (p > q && p > r)
            {
                Console.WriteLine("one and two farther from each other");
            }
            else if (q > r && q > p)
            {
                Console.WriteLine("two and three farther from each other");
            }

            else if (r > p && r > q)
            {
                Console.WriteLine(" three and one farther from each other");
            }
            else
            {
                Console.WriteLine("not farther from each other");
            }

        }
        static void Qset2_13()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());


            int getmax = Math.Max(a, Math.Max(b, c));
            //Console.WriteLine("first" + getmax);



            int getmin = Math.Min(a, Math.Min(b, c));
            //Console.WriteLine("second" + getmin);

            int getmiddle = (a + b + c) - getmax - getmin;

            Console.WriteLine("sort" + " " + getmin + " " + getmiddle + " " + getmax);

        }
        static void Qset2_14()
        {
             Console.WriteLine("Check whether a triangle");

              Console.WriteLine("Enter the number 1");
              int num1 = int.Parse(Console.ReadLine());
              Console.WriteLine("The number one is " + num1);

              Console.WriteLine("Enter the number 1");
              int num2 = int.Parse(Console.ReadLine());
              Console.WriteLine("The number one is " + num2);

              Console.WriteLine("Enter the number 1");
              int num3 = int.Parse(Console.ReadLine());
              Console.WriteLine("The number one is " + num3);

              if (num1 == num2 && num1 == num3 && num2 == num3)
              {
                  Console.WriteLine(" It is a triangle");
              }
              else
              {
                  Console.WriteLine("It is not a triangle");

              }
          
        }
        static void Qset2_15()
        {
            Console.WriteLine("Coordinate points");

            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("The Value X is" + num1);

            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The Value Y is" + num2);

            if (num1 == 0 && num2 == 0)
            {
                Console.WriteLine("Origin");
            }

            else if (num1 == 0 && num2 != 0)
            {
                Console.WriteLine(" X-axis");
            }
            else if (num1 != 0 && num2 == 0)
            {
                Console.WriteLine(" Y-axis");
            }

            else if (num1 > 0 && num2 > 0)
            {
                Console.WriteLine("Points are first coordinate");
            }
            else if (num1 > 0 && num2 < 0)
            {
                Console.WriteLine("Points are second coordinate");
            }
            else if (num1 < 0 && num2 < 0)
            {
                Console.WriteLine("Points are third coordinate");
            }
            else if (num1 < 0 && num2 > 0)
            {
                Console.WriteLine("Points are fourth coordinate");
            }
            else
            {
                Console.WriteLine("Invalid ");
            }

        }
        static void Qset2_16()
        {
            Console.WriteLine("Find a vowel or constant");

            Console.WriteLine("Enter the vowel words");
            char word = char.Parse(Console.ReadLine());
            Console.WriteLine("the vowel word is " + word);

            switch (word)
            {
                case 'a':


                    Console.WriteLine("It is a vowel");
                    break;
                case 'e':
                    Console.WriteLine("It is a vowel");
                    break;
                case 'i':
                    Console.WriteLine("It is a vowel");
                    break;
                case 'o':
                    Console.WriteLine("It is a vowel");
                    break;
                case 'u':
                    Console.WriteLine("It is a vowel");
                    break;
                case 'A':
                    Console.WriteLine("It is a vowel");
                    break;
                case 'E':
                    Console.WriteLine("It is a vowel");
                    break;
                case 'I':
                    Console.WriteLine("It is a vowel");
                    break;
                case 'O':
                    Console.WriteLine("It is a vowel");
                    break;
                case 'U':
                    Console.WriteLine("It is a vowel");
                    break;
                default:
                    Console.WriteLine("not vowel");
                    break;
            }
        }
        static void Qset2_17()
        {
            Console.WriteLine("Types of shapename");
            Console.WriteLine("Enter the shapename below 8 values");
            int shapename = int.Parse(Console.ReadLine());

            switch (shapename)
            {
                case 1:
                    Console.WriteLine("Triangle");
                    break;

                case 2:
                    Console.WriteLine("Isosceles");
                    break;
                case 3:
                    Console.WriteLine("Scalene");
                    break;
                case 4:
                    Console.WriteLine("Equiangular");
                    break;
                case 5:
                    Console.WriteLine("Acute angle");
                    break;
                case 6:
                    Console.WriteLine("Right angle");
                    break;
                case 7:
                    Console.WriteLine("obtuse angle");
                    break;
                default:
                    Console.WriteLine("Invalid data");
                    break;
            }
        }
        static void Qset2_18()
        {

            Console.WriteLine("Number of days in a month given the month name:");

            Console.WriteLine("Enter the month name:");
            string monthname = (Console.ReadLine());

            if (monthname.ToLower() == "january")
            {
                Console.WriteLine("31");
            }
            else if (monthname.ToLower() == "april" + "june" + "september" + "november")
            {
                Console.WriteLine("30");
            }

            else if (monthname.ToLower() == "february")
            {
                Console.WriteLine("28");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
        static void Qset2_19()
        {
            Console.WriteLine("Print the day of week");
            Console.WriteLine("enter the date");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The week days:" + number);
            int p = (number % 7);


            Console.WriteLine("the Value is" + p);


            switch (p)
            {
                case 0:
                    Console.WriteLine("sunday");
                    break;
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thursday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
            }

        }
        static void Qset2_20()
        {
            Console.WriteLine(" find the triangle types");

            Console.WriteLine("Enter the number 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("The number one is " + num1);

            Console.WriteLine("Enter the number 1");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The number one is " + num2);

            Console.WriteLine("Enter the number 1");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("The number one is " + num3);

            if (num1 == num2 && num1 == num3 && num2 == num3)
            {
                Console.WriteLine(" Equilateral triangle");
            }
            else if (num1 == num2 || num2 == num3 || num3 == num1)
            {
                Console.WriteLine(" Isosceles triangle");
            }
            else if (num1 != num2 && num1 != num3 && num2 != num3)
            {
                Console.WriteLine("Scalen triangle");
            }
            else
            {
                Console.WriteLine(" Invalid ");
            }
        }
        static void Qset2_21()
        {
            Console.WriteLine("Convert grade points to letter grades");

            Console.WriteLine("Enter the grades below 100");
            int mark = int.Parse(Console.ReadLine());
            Console.WriteLine(" The number one :" + mark);
            if (mark > 90 && mark <= 100)
            {
                Console.WriteLine("A");
            }

            else if (mark > 80 && mark <= 90)
            {
                Console.WriteLine("B");
            }
            else if (mark > 70 && mark <= 80)
            {
                Console.WriteLine("C");
            }
            else if (mark > 50 && mark <= 70)
            {
                Console.WriteLine("D");
            }
            else if (mark > 0 && mark <= 50)
            {
                Console.WriteLine("Fail");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        static void Qset2_22()
        {
            Console.WriteLine("Find the chess board colors");
            Console.WriteLine("Enter the row  values upto (1-8)");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the column values(a-h)");
            char column = char.Parse(Console.ReadLine());
            int columnIndex = column - 'a' + 1;
            Console.WriteLine(columnIndex);
            // int rowIndex = row - 1;
            //Console.WriteLine(rowIndex);
            int totalIndex = row + columnIndex;
            Console.WriteLine(totalIndex);
            if (totalIndex % 2 == 0)
            {
                Console.WriteLine(" black");
            }
            else
            {
                Console.WriteLine(" white ");
            }
        }
        static void Qset2_23()
        {
            Console.WriteLine("Calculate the root of Quadratic equation");

            Console.WriteLine("Enter the value a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine(" The value a is " + a);

            Console.WriteLine("Enter the value b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(" The value b is " + b);

            Console.WriteLine("Enter the value c");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine(" The value c is " + c);

            double d, r1, r2;
            int m;
            d = (b * b) - (4 * a * c);
            Console.WriteLine("The  value d is:" + d);
            if (a == 0)
                m = 1;
            else if (d > 0)
                m = 2;
            else if (d == 0)
                m = 3;
            else
                m = 4;
            switch (m)
            {
                case 1:
                    Console.WriteLine("Its not a quadratic equation:");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("     The roots are real and distinction value:");
                    r1 = -b + (Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("The root one value is:" + r1);
                    r2 = -b - (Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("The root two value is:" + r2);
                    break;

                case 3:
                    Console.WriteLine("It is a real and equal"); //a=1,b=-2,c=1
                    r1 = r2 = (-b) / (2 * a);
                    Console.WriteLine("The root one value is:" + r1);

                    Console.WriteLine("The root two value is:" + r2);
                    break;

                case 4:
                    Console.WriteLine("It is a real and imaginary :");
                    r1 = (-b) / (2 * a);
                    r2 = Math.Sqrt(-d) / (2 * a);
                    Console.WriteLine("The root one value is " + r1, r2);
                    Console.WriteLine("The root two value is " + r1, r2);

                    break;
            }
        }
        static void Qset2_24()
        {
            {
                Console.WriteLine("Calculate profit or Loss");

                Console.WriteLine("Enter the number costprice");
                double costprice = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the number sellingprice");
                double sellingprice = double.Parse(Console.ReadLine());


                /*  double profit = sellingprice - costprice;
                   {
                       Console.WriteLine(profit);
                   }

                   double  loss = costprice - sellingprice;
                   {
                   Console.WriteLine(loss);
                   } */

                if (sellingprice == costprice)
                {
                    Console.WriteLine("Nor profit and Loss");
                }
                else if (costprice < sellingprice)
                {
                    Console.WriteLine("profit");
                }

                else if (costprice > sellingprice)
                {
                    Console.WriteLine("Loss");
                }
                else
                {

                    Console.WriteLine("Invalid");
                }
            }
        }
        static void Qset2_24()
        {
            {
                Console.WriteLine("Menu driven program");

                Console.WriteLine("MENU ,1. Addition,2. subtraction,3. multiplicatio,4. division ,5. modulo division ");

                Console.WriteLine("Enter the menu number ");
                int num1 = int.Parse(Console.ReadLine());


                switch (num1)
                {
                    case 1:
                        Console.WriteLine("Enter the  add no. 1");
                        double n1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the add no. 2");
                        double n2 = double.Parse(Console.ReadLine());
                        double sum = n1 + n2;
                        Console.WriteLine("addition value is" + sum);
                        break;

                    case 2:
                        Console.WriteLine("Enter the  sub no.1");
                        double m = double.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the sub no. 2");
                        double n = double.Parse(Console.ReadLine());
                        double sub = m - n;
                        Console.WriteLine("subtraction value is" + sub);
                        break;

                    case 3:
                        Console.WriteLine("Enter the  mul no.1");
                        double p = double.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the mul no. 2");
                        double q = double.Parse(Console.ReadLine());
                        double mul = p * q;
                        Console.WriteLine("multiplication value is" + mul);
                        break;

                    case 4:
                        Console.WriteLine("Enter the  div no.1");
                        double a = double.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the div no. 2");
                        double b = double.Parse(Console.ReadLine());
                        double div = a / b;
                        Console.WriteLine("division value is" + div);
                        break;

                    case 5:
                        Console.WriteLine("Enter the  modulo division no.1");
                        double c = double.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the modulo division 2");
                        double d = double.Parse(Console.ReadLine());
                        double mdiv = c % d;
                        Console.WriteLine("modulo division value is" + mdiv);
                        break;
                }
            }
        }
        static void Qset2_24()
        {
            {
                Console.WriteLine("play the Rock, Paper ,Scissors");


                int computerNum;

                Console.WriteLine("Choose the 1.Rock , 2.Paper , 3. Scissor");
                int userNum = int.Parse(Console.ReadLine());

                Random random = new Random();
                computerNum = random.Next(1, 4);

                Console.WriteLine("computer number" + computerNum);
                if (userNum == computerNum)
                {
                    Console.WriteLine("draw");
                }
                else if ((userNum == 1 && computerNum == 3) || (userNum == 2 && computerNum == 1) || (userNum == 3 && computerNum == 2))
                {
                    Console.WriteLine("YOU win");
                }
                else
                {

                    Console.WriteLine("computer win");

                }
                Console.WriteLine();
            }

        }
    }
}
