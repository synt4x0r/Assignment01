namespace Demo
{
    internal class Program
    {
        // entry point
        static void Main(string[] args)
        {
            #region var_dec
            //// variable declaration
            //// datatype variablename;


            //int Number; // Declare Variable
            //// Allocate UnInitialized 4 Bytes At Memory

            ////Console.WriteLine(Number); // Invalid

            //Number = 5;
            ////variable
            //// 1. Name      :Number
            //// 2. Datatype: :int 
            //// 3. Size      :4 Bytes
            //// 4. Value     :5 
            //// 5. Address : 0xF2A

            ////Console.WriteLine(Number); // 5

            ////int Number = 5; // Declaration And Initialization For The Number

            ////Console.WriteLine(Number);

            ////int Number01;
            ////int Number02;
            ////int Number03;

            ////int Number01 = 2, Number02 = 3, Number03,

            ////Console.WriteLine(Number01); //2
            ////Number01 = 7;
            ////Console.WriteLine(Number01);
            ////Console.WriteLine(Number03); 
            #endregion

            #region datatype
            //// Datatype (Value Type): Stacki

            //// Declare Variable

            //int Number; // Value Type

            //// Allocate UnInitialized 4 Bytes At Stack

            //// int : C# Keyword

            //// BCL: Int32

            //Int32 Number02;

            //Number = 12;

            ////Console.WriteLine(Number02);
            #endregion

            #region point
            //Point P01; //reference
            //// declare reference from 'Point'
            //// 8 bytes will be allocated at stack
            //// 0 bytes will be allocated at heap

            //Console.WriteLine(P01);

            //Console.WriteLine(P01.X); // invalid

            //P01 = new Point();
            //// new
            //// 1. allocate place at heap
            //// 2. initialize the allocation with default value
            //// 3. call user-define construtor if exist
            //// 4. assign the object address to the reference 'P01'

            //Console.WriteLine(P01.X);// 0
            //Console.WriteLine(P01.Y);// 0
            //Console.WriteLine(P01);  // namespace



            //Point P02 = new Point();

            //P02.X = 12;

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P02.X);

            //P01 = P02;

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P02.X);
            #endregion


            #region object
            //object 001;
            //// declare for reference from type 'object'
            //// 001: can refer to instance from type 'object' or any type inherited from object


            //001 = new object();
            //001 = 1;
            //001 = 'A';
            //001 = 1.2;
            //001 = true;
            //001 = new Point();

            //Console.WriteLine(001.GetHashCode()); // id : indication for the address

            //Console.WriteLine(001); // namespace

            //Point P01 = new Point();
            //Console.WriteLine(P01.GetHashCode()); // id 
            #endregion

            #region casting
            //casting : converting datatype
            // 1. implicit casting

            //int X = 5;

            //double Y = /*(double)*/ X; // implicit casting (safe)

            //Console.WriteLine(Y);


            //// 2. explicit casting

            //double X = 2.5;

            //int Y = (int) X; // explicit cast (unsafe)
            //Console.WriteLine(Y);


            //long X = 111111111111111111111111;

            //int Y = (int) X; // explicit
            //Console.WriteLine(Y);

            //Console.WriteLine(int.MaxValue); 
            #endregion

            #region convert,parse,tryparse
            // parse : function

            //Console.WriteLine(value:"Enter your Age: ");
            //int Age = int.Parse(Console.ReadLine());

            //Console.WriteLine(value: "Enter your GPA: ");
            //double GPA = double.Parse(Console.ReadLine());

            //Console.WriteLine("Age : " + Age);
            //Console.WriteLine("GPA : " + GPA);

            // convert : class

            //Console.WriteLine(value: "Enter your Age: ");
            //int Age = Convert.ToInt32(Console.ReadLine());


            ////Console.WriteLine(value: "Enter your GPA: ");
            ////double GPA = double.Parse(Console.ReadLine());

            //Console.WriteLine("Age : " + Age);
            ////Console.WriteLine("GPA : " + GPA);


            // tryparse

            //Console.WriteLine(value: "Enter your Age: ");

            //int Age;
            //bool Flag = int.TryParse(Console.ReadLine(), out Age);

            ////Console.WriteLine(value: "Enter your GPA: ");
            ////double GPA = double.Parse(Console.ReadLine());

            //Console.WriteLine("Age : " + Age);
            ////Console.WriteLine("GPA : " + GPA); 
            #endregion


            #region fractions & discrads
            //double X = 1.5;
            //float Y = 1.5F;

            //decimal Z = 1.5m;


            //    int X = 1_000_000_000; // Discard

            //    Console.WriteLine(X);
            //}
            #endregion

            #region operators
            //1. Unary Operators -> Works On One Operand (Variable) ++ 
            //int X = 10;

            // ++
            //Prefix [Increment then print]
            //Console.WriteLine(++X); // 11 
            //PostFix [Print then Increment]
            //Console.WriteLine(X++); // 10 
            //Console.WriteLine(X); // 11


            //
            //Prefix [decrement then print]
            //Console.WriteLine(--X); // 9
            //PostFix [Print then decrement] 
            //Console.WriteLine(X--); // 10 
            //Console.WriteLine(X); // 9

            //=====================================

            //2. Binary Operators => Works on Two Operands (Variables)
            // + = / * %
            //int Sum, Mul, Sub, Mod;
            //int Number01 = 2, Number02 = 6;

            //Sum = Number01 + Number02; // 8 
            //Mul = Number01 Number02; // 12
            //Sub = Number01 Number02; // -4 
            //Mod Number01 % Number02; // 2 
            // 23 % 3 = 2

            //=======================================
            //3. Assignment Operators

            //int X; //X = 4;
            //X += 2; // X = X + 2 // 6 
            //X -= 2; // X = X - 2
            //X *= 2; // X = X * 2
            //X /= 2; // X = X / 2
            //X %= 2; // X = X % 2




            //4. Relational Operators


            //int X = 6, Y = 5;
            //Console.WriteLine(X == Y);
            //Console.WriteLine(X != Y);
            //Console.WriteLine(X > Y);
            //Console.WriteLine(X < Y);
            //Console.WriteLine(X >= Y);
            //Console.WriteLine(x <= Y);

            //5. Logical Operators [AND, OR, NOT]
            //Console.WriteLine(!false); // ! -> Not
            //Console.WriteLine(false && true); // && -> AND Short Circuit 
            //Console.WriteLine(false || true); // || -> OR Short Circuit

            //6. Bitwise Operators
            //Console.WriteLine(!false); // ! -> Not
            //Console.WriteLine(false && true); // && -> AND Long Circuit
            //Console.WriteLine(false || true); // || -> OR Long Circuit

            //7. Ternary Operator 


            //bool flag = 4 > 2;
            //Console.WriteLine(flag);
            //string flag = 4 < 2 ? "Correct" : "Not Correct";
            //Console.WriteLine(flag); 
            #endregion

        }
    }
