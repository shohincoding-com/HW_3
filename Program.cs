using System;

namespace HW_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task_1
            int a, b;
            Console.WriteLine("Enter first number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            b = int.Parse(Console.ReadLine());
            if (a != b){
                a = a > b ? a : b;
                b = a;
            }
            else
            {
                a = 0;
                b = 0;
            }
            Console.WriteLine($"A = {a}\nB = {b}\nEndTask_1");
            //EndTask_1

            //Task_2
            double opereand1, opereand2, result = 0;
            char sign = ' ';
            Console.WriteLine("\nEnter first number");
            opereand1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the arithmetic operation");
            sign = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            opereand2 = double.Parse(Console.ReadLine());
            if(sign == '/' && opereand1 == 0){
                Console.WriteLine("Error operand1!\nEndTask_2");
            }
            else if(sign == '/' && opereand2 == 0){
                 Console.WriteLine("Error operand2!\nEndTask_2");
            }
            else{
                switch(sign){
                    case '*' : result = opereand1 * opereand2; break;
                    case '/' : result = opereand1 / opereand2; break;
                    case '+' : result = opereand1 + opereand2; break;
                    case '-' : result = opereand1 - opereand2; break;
                }
                Console.WriteLine($"{result} EndTask_2");
            }
            //EndTask_2

            //Task_3
            Console.WriteLine("\nPlease enter from 0 to 100!");
            int A = int.Parse(Console.ReadLine());
            string answer = A > -1 && A < 15 ? "[0 - 14]" : "You entered the wrong numbers";
            answer = A > 14 && A < 36 ? "[15 - 35]" : answer;
            answer = A > 35 && A < 51 ? "[36 - 50]" : answer;
            answer = A > 49 && A < 101 ? "[50 - 100]" : answer;
            Console.WriteLine($"{answer}\nEndTask_3");
            //EndTask_3
        }
    }
}
