using System;

namespace Median
{
    class Program
    {
        public class Value
        {
            public int i = 0;

            public Value(int i)
            {
                this.i = i;
            }
        }

        static void Main(string[] args)
        {
            Value val1 = new Value(2);
            Value val2 = new Value(7);
            Value val3 = new Value(2);
            Value val4 = new Value(8);
            
            Write.Do(val1, val2);
            Console.WriteLine("after do : {0}; {1} " , val1.i , val2.i);
            Write.Do1(ref val3, val4);
            Console.WriteLine("after do1 : {0}; {1} " , val3.i, val4.i);
            Console.ReadLine();
        }

        public static class Write
        {
            public static void Do(Value val1, Value val2)
            {
                val1.i = val2.i;
                val2.i = val1.i + val2.i;
            }

            public static void Do1(ref Value val3, Value val4)
            {
                val3.i = val4.i;
                val4.i = val3.i + val4.i;
            }
        }
    }
}
