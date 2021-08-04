using System;

namespace ProgramStructure
{
        class Program
    {
        static void Main(string[] args)
        {
            var st = new Stack();

            st.Push(1);
            st.Push(10);
            st.Push(100);

            System.Console.WriteLine(st.Pop());
            System.Console.WriteLine(st.Pop());
            System.Console.WriteLine(st.Pop());
        }
    }
}
