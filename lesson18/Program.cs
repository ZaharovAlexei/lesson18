using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson18
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы.
            Проверить, корректно ли в ней расставлены скобки. Например, в строке ([]{})[] скобки расставлены корректно, а в строке ([]] — нет.
            Указание: задача решается однократным проходом по символам заданной строки слева направо;
            для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая, 
            каждая закрывающая скобка в строке должна соответствовать скобке из вершины стека (при этом скобка с вершины стека снимается);
            в конце прохода стек должен быть пуст.*/

            Stack < char > brackets = new Stack<char>();
            string line = "({x-y-z}*[x+2y]-(z+4x))";
            char[] chars = line.ToCharArray();
            foreach (char i in chars)
            {
                switch (i)
                {
                    case '[':
                        {
                            brackets.Push(']');
                            break;
                        }
                    case ']':
                        {
                            if (i==brackets.Peek())
                            {
                                brackets.Pop();
                            }
                            break;
                        }
                    case '(':
                        {
                            brackets.Push(')');
                            break;
                        }
                    case ')':
                        {
                            if (i == brackets.Peek())
                            {
                                brackets.Pop();
                            }
                            break;
                        }
                    case '{':
                        {
                            brackets.Push('}');
                            break;
                        }
                    case '}':
                        {
                            if (i == brackets.Peek())
                            {
                                brackets.Pop();
                            }
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            foreach (char i in brackets)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            if (brackets.Count()>0)
            {
                Console.WriteLine("Скобки расставлены не правильно");
            }
            else
            {
                Console.WriteLine("Скобки расставлены правильно");
            }
            Console.ReadKey();
        }
    }
}
