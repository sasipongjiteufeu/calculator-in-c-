using System;

namespace calculator{
    class Program{
        static void Main(string[] args){
            int num1 = 0,num2 = 0,num3 = 0;
            
            
            Console.WriteLine("pick one");
            Console.WriteLine("\n1) + \n 2) - \n 3) * \n 4) / \n 5) % \n");
            string menu = Console.ReadLine();
            Console.WriteLine("Your pick is " + menu);
            Console.WriteLine("input your number_1\n");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input your number_2\n");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            calculator_Logic myObj = new calculator_Logic();

            if(menu == "+"){
            myObj.sum(num1,num2);
            Console.WriteLine(myObj.answer);
            }
            else if (menu == "-"){
            myObj.subtract(num1,num2);
            Console.WriteLine(myObj.answer); 
            }
            else if (menu == "*"){
            myObj.multiply(num1,num2);
            Console.WriteLine(myObj.answer);
            }
            else if (menu == "/"){
            myObj.divide(num1,num2);
            Console.WriteLine(myObj.answer);
            }
            else if (menu == "%"){
            myObj.Modulus(num1,num2);
            Console.WriteLine(myObj.answer);
            }



        } 
    }
}

