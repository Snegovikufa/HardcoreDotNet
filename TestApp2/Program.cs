using System;

namespace TestApp2
{
    internal class SomeClass
    {
        private readonly int _id;

        public SomeClass(int id)
        {
            _id = id;
        }

        public override string ToString()
        {
            return _id.ToString();
        }
    }

    internal static class Program
    {
        private static readonly SomeClass[] SomeClasses =
        {
            new SomeClass(1)
        };

        private static ref readonly SomeClass GetRef()
        {
            return ref SomeClasses[0];
        }

        private static void TryToChangeRef(ref SomeClass f)
        {
            f = new SomeClass(2);
        }

        public static void Main()
        {
            var f = GetRef();
            TryToChangeRef(ref SomeClasses[0]);
            Console.WriteLine(SomeClasses[0].ToString());
            Console.WriteLine(f.ToString());
        }
    }
}
