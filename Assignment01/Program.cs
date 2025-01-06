using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Assignment01
{
    class point
    {
        public int x;
        public int y;
    }
    internal class Program
    {

        static void Main()
        {

            #region Q1

            //Console.WriteLine("Enter Number");
            //int Num = int.Parse(Console.ReadLine());

            //Console.WriteLine("Number : " + Num);
            #endregion

            #region Q2

            //Console.WriteLine(value:"Enter String");
            //int Num = Convert.ToInt32 (Console.ReadLine());

            //Console.WriteLine(Num);

            //it cant be done because its not in the correct format
            #endregion

            #region Q3

            //Console.WriteLine(value: "Enter Number");
            //double Num1 = double.Parse(Console.ReadLine());

            //Console.WriteLine(value: "Enter Number");
            //double Num2 = double.Parse(Console.ReadLine());

            //double sum = Num1 + Num2;
            //Console.WriteLine(sum);

            // it will sum the two variables
            #endregion


            #region Q4

            //string str = "The Matrix";
            //string substr = str.Substring(0, 3);
            //string substr2 = str.Substring(4);
            //Console.WriteLine(substr2);
            #endregion

            #region Q5

            //double x = 1.2;
            //double y = x;
            //x = 1.5;
            //Console.WriteLine(x); // 1.5
            //Console.WriteLine(y); // 1.2

            // it cant see what modification after its assigned to one variable
            #endregion

            #region Q6

            //point p1 = new point();
            //point p2 = new point();

            //p1.x = 4;
            //p1.y = 5;

            //p2 = p1;

            //p2.x = 6;
            //p1.y = 9;

            //Console.WriteLine($"{p1.x},{p1.y}"); // // $" to type string mixed with {variable}"
            //Console.WriteLine($"{p2.x},{p2.y}"); // 
            //it will change because its reference type saves the address no matter when modifications occured
            #endregion

            #region Q7

            //Console.WriteLine("enter 1st string");
            //string str1 = Console.ReadLine();

            //Console.WriteLine("enter 2nd string");
            //string str2 = Console.ReadLine();

            //Console.WriteLine(str1 + " " + str2);
            #endregion

            #region Q8

            //int pamount = 5, rate = 6, time = 10;
            //int intrst = (pamount * rate * time) / 100;

            //Console.WriteLine(intrst);
            #endregion

            #region Q9

            //double weight = 70, height = 1.8;
            //double bmi = (weight) / (height * height);

            //Console.WriteLine(bmi);
            #endregion

            #region Q10

            //while (true)
            //{
            //    Console.Write("Enter The Degree Of Temp.: ");
            //    int temp = int.Parse(Console.ReadLine());
            //    string output = (temp < 10 ? "Just Cold" : temp > 30 ? "Just Hot" : "Just Good");
            //    Console.WriteLine(output);
            //}
            #endregion

            #region Q11

            //Console.Write("Enter Day: ");
            //int day = int.Parse(Console.ReadLine());
            //Console.Write("Enter Month: ");
            //int month = int.Parse(Console.ReadLine());
            //Console.Write("Enter Year: ");
            //int year = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Today's date : {day} , {month} , {year}");
            //Console.WriteLine($"Today's date : {day} / {month} / {year}");
            //Console.WriteLine($"Today's date : {day} - {month} - {year}");
            #endregion

            #region Q12

            //DateTime date = new DateTime(2024, 6, 14);
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
            //// the output > The event is on  06/ 14/2024 c)
            // MM/dd/yyyy is defined in c# // though DateTime is (year, month, day)
            #endregion

            #region Q13

            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //Console.WriteLine(d);
            //// ! = not (opposite) // so it will be assigned to 1 because its true f)
            //// if ! is removed it will be assigned to 0 (false)
            #endregion

            #region Q14

            //Console.WriteLine(13 / 2 + " " + 13 % 2);
            // output > 6 1 d)
            // not 6.5 because its int division
            #endregion

            #region Q15

            //int num = 1, z = 5;

            //if ((num >= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);

            //int num = 1, z = 5;

            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);
            //// output >> 77
            #endregion
        }

    }
}// git commit
