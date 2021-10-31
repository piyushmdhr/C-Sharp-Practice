using System;

namespace Programs
{
    public class Q
    {
        // *** OUESTION 1 ***

        public static void q1()
        {
            // Get age from user
            Console.WriteLine("Enter your age:");
            string age = Console.ReadLine();

            // Prepare string for output
            // string output = "You are " + age + " years old";
            string output = $"Your are {age} years old";

            // Show the output to user 
            Console.WriteLine(output);
        }

        // ***QUESTION 2 ***

        //     public static void q2(){
        //         Console.WriteLine("Enter 3 Integers");

        //         string int1= Console.ReadLine();
        //         string int2= Console.ReadLine();
        //         string int3= Console.ReadLine();

        //         int i1 = int.Parse(int1);
        //         int i2 = int.Parse(int2);
        //         int i3 = int.Parse(int3);

        //         int max = 0;
        //          if(i1 > i2 && i1>i3){
        //              max= i1;
        //          }
        //          else if (i2> i1 && i2>i3){
        //              max= i2;
        //          }
        //          else{
        //              max=i3;
        //          }

        // string output = $"The greatest integer is {max}";

        // Console.WriteLine(output);
        //     }

        // *** QUESTION 3 ***

        // public static void q3(){

        //     Console.WriteLine("Enter Your First Name:");
        //     string name = Console.ReadLine();
        //     string output = $"Hello {name}!";
        //     Console.WriteLine(output);
        // }

        // ***QUESTION 4 ***
        // public static void q4(){
        //     Console.WriteLine("Enter the Limit");

        //     string limit = Console.ReadLine();

        //      int lim = int.Parse(limit);

        //     Console.WriteLine($"Enter {lim} integers:");

        //     int[] numbers=new int[lim];

        //     for(int i=0;i<lim;i++){
        //         Console.WriteLine("Enter a number ");
        //         numbers[i]=int.Parse(Console.ReadLine());
        //     }

        //     int max = numbers[0];

        //     for (int i = 1; i < lim; i++){

        //         if (max<numbers[i]){
        //             max = numbers[i];

        //         }

        //     }

        // string output = $"The greatest number is {max}";
        // Console.WriteLine(output);

        // }

        // }

        // ***QUESTION 5A***
        // public static void q5a(){
        //     Console.WriteLine("Enter First Number:");
        //     string int1= Console.ReadLine();

        //     Console.WriteLine("Enter Operator:");
        //     string op = Console.ReadLine();

        //     Console.WriteLine("Enter second number:");
        //     string int2= Console.ReadLine();

        //     int i1 = int.Parse(int1);
        //     int i2 = int.Parse(int2);

        //     int result = 0;

        //     if (op == "+"){
        //         result = i1+i2;    
        //     }
        //     else if (op == "-"){
        //         result = i1 - i2;
        //     }
        //     else if (op == "*"){
        //         result = i1 * i2;
        //     }
        //     else if (op == "/"){
        //         result = i1 / i2;
        //     }
        //     else{
        //         Console.WriteLine("Please enter valid operator.");
        //     }

        //     Console.WriteLine(result);


        // }
        // }

        // ***QUESTION 5B***
        // public static void q5b(){
        //     Console.WriteLine("Enter First Number:");
        //     string int1= Console.ReadLine();

        //     Console.WriteLine("Enter Operator:");
        //     string op = Console.ReadLine();

        //     Console.WriteLine("Enter second number:");
        //     string int2= Console.ReadLine();

        //     int i1 = int.Parse(int1);
        //     int i2 = int.Parse(int2);

        //     int result = 0;

        //     switch(op){
        //         case "+":
        //             result = i1+i2; 
        //             Console.WriteLine($"The addition is: {result}");
        //             break;

        //         case "-":
        //             result = i1-i2; 
        //             Console.WriteLine($"The subtraction is: {result}");
        //             break;

        //         case "*":
        //             result = i1*i2; 
        //             Console.WriteLine($"The product is: {result}");
        //             break;

        //         case "/":
        //             result = i1/i2; 
        //             Console.WriteLine($"The quotient is: {result}");
        //             break;

        //         default :
        //             Console.WriteLine("Please enter a valid operator.");
        //             break;
        //     }

        // }

        // ***QUESTION 6***
        // public static void q6()
        // {
        //     for (int i = 1; i <= 7; i++)
        //     {
        //         for (int j = 1; j <= 7; j++)
        //         {
        //             if (i >= j)
        //             {
        //                 Console.Write(j);
        //             }
        //             else
        //             {
        //                 Console.Write("*");
        //             }
        //         }
        //         Console.WriteLine("\n");
        //     }
        // }


        // ***QUESTION 7***
        // public static void q7()
        // {
        //     Console.WriteLine("Enter first-term score, mid-term score, and final score:");

        //     String score1 = Console.ReadLine();
        //     String score2 = Console.ReadLine();
        //     String score3 = Console.ReadLine();

        //     float s1 = float.Parse(score1);
        //     float s2 = float.Parse(score2);
        //     float s3 = float.Parse(score3);

        //     float avg = ((s1 + s2 + s3) / 3);

        //     Console.WriteLine($"You acheived {avg}%");

        //     if (avg >= 90)
        //     {
        //         Console.WriteLine("Grade A");
        //     }
        //     else if (avg >= 70 && avg < 90)
        //     {
        //         Console.WriteLine("Grade B");
        //     }
        //     else if (avg >= 50 && avg < 70)
        //     {
        //         Console.WriteLine("Grade C");
        //     }
        //     else if (avg >= 35 && avg < 50)
        //     {
        //         Console.WriteLine("Grade D");
        //     }
        //     else if (avg < 35)
        //     {
        //         Console.WriteLine("Grade E");
        //     }

        // }


        // ***QUESTION 8***
        // public static void q8()
        // {
        //     Console.WriteLine("Enter First Number:");

        //     string num1 = Console.ReadLine();
        //     int n1 = int.Parse(num1);

        //     Console.WriteLine("Enter Second Number:");
        //     string num2 = Console.ReadLine();
        //     float n2 = float.Parse(num2);

        //     Console.WriteLine("Enter Third Number:");
        //     string num3 = Console.ReadLine();

        //     //display values
        //     Console.WriteLine(n1);
        //     Console.WriteLine(n2);
        //     Console.WriteLine(num3);

        //     // add values in floating point and display sum
        //     float n3 = float.Parse(num3);
        //     float sum = n1 + n2 + n3;
        //     Console.WriteLine($"The Sum Is {sum}");

        //     // concate values
        //     String merge = String.Concat(n1, n2, num3);
        //     Console.WriteLine($"The Concate Value Is {merge}");

        // }


        // ***QUESTION 9***
        // public static void q9()
        // {
        //     Console.WriteLine("Guess a number from 1 to 10:");
        //     int guess = int.Parse(Console.ReadLine());
        //     Random rnd = new Random();
        //     int num = rnd.Next(1, 10);
        //     if (guess == num)
        //     {
        //         Console.WriteLine("You guessed right. 😀 ");
        //     }
        //     else
        //     {
        //         Console.WriteLine("You guessed wrong. Bad Luck. 👍 ");
        //     }
        // }




    }
}


