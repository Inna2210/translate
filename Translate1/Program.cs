using System;
using System.Collections.Generic;

namespace Translate
{
    class Program
    {
        static public Stack<int> FindTheRemainder(int x)
        {
            Stack<int> _number = new ();
            
            while (Math.Abs(x) > 15)
            {
                _number.Push(Math.Abs(x) % 16);
                x = x / 16;
            }
            _number.Push(x);
            
            return _number;
        }

         static public List<string> Translate(Stack<int> _number)
         {
            List<string> number = new();
            List<string> vocabulary = new() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f" };

            if (_number.Peek() < 0)
            {
                number.Add("-");
            }
           
            foreach (int i in _number)
            {
                number.Add(vocabulary[Math.Abs(i)]);
            }

            return number;
         }

        static void Main(string[] args)
        {
            do
            {
                string line = Console.ReadLine(); // ввод числа в десятеричной системе 
                int x = int.Parse(line);
                Stack<int> _number = FindTheRemainder(x);
                List<string> number = Translate(_number);
                string answer = String.Join("", number);
                Console.WriteLine(answer);
            }
            while (true);
        }
    }
}
