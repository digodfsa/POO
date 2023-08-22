using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();

        }

        static void menu()
        {
            Console.WriteLine(" bem vindo a calculadora :");
            Console.WriteLine(" oq vc deseja realizar ");
            Console.WriteLine("escolha a opreção : (+ - x /):");
            char op = char.Parse(Console.ReadLine());
       
            conta(op);

        }


        static void conta(char op)
        {
            Console.WriteLine("escolha um numero :");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("escolha outra numero :");
            double num2 = double.Parse(Console.ReadLine());
            double result = 0;
            switch (op)
            {
                case '+':
                    Console.WriteLine("vc escolheu a opção de soma :");
                    Console.WriteLine("--------------------------");
                    result= num1 + num2;
                    Console.WriteLine($"o resultado da soma é :{result}");
                    break;




                case '-':
                    Console.WriteLine("vc escolheu a opção de subtração :");
                    Console.WriteLine("--------------------------");
                    result= num2 - num1;
                    Console.WriteLine($"o resultado da subtração :{result}");
                    break;


                case 'x':
                case '*':
                    Console.WriteLine("vc escolheu a opção de multiplicação :");
                    Console.WriteLine("--------------------------");
                    result= num1 * num2;
                    Console.WriteLine($"o resultado da multiplicação:{result}");
                    break;


                case '/':
                    Console.WriteLine("vc escolheu a opção de divisão :");
                    Console.WriteLine("--------------------------");
                    result = num1 / num2;
                    Console.WriteLine($"o resultado da divisão : {result}");
                    break;


                default:
                    Console.WriteLine("erro ");
                    break;
            }
            Console.ReadKey();
        }
    }







}

