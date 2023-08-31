using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaciones_basicas_pila
{
    internal class Program  {
        static int maxSize = 10;
        static int[] stackArray = new int[maxSize];
        static int top = -1;

        static void Push(int item){
            if (top < maxSize - 1)
            {
                stackArray[++top] = item;
            }
            else
            {
                Console.WriteLine("Stack Overflow");
            }
        }

        static int Pop(){
            if (top >= 0)
            {
                return stackArray[top--];
            }
            else
            {
                Console.WriteLine("Stack Underflow");
                return -1; // or throw an exception
            }
        }
                static void Main(string[] args)
        {
            Push(10);
            Push(20);
            Push(30);

            Console.WriteLine("Popped: " + Pop()); // Output: 30
            Console.WriteLine("Popped: " + Pop()); // Output: 20
            Console.ReadLine();
        }
    }
}
