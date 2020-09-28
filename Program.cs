using System;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Generic<int> n = new  Generic<int>();
            n.Generics<int>(1, 2);
            n.Generics<int>(3, 3);
            Generic<string> m = new  Generic<string>();
            m.Generics<string>("mot", "hai");
            m.Generics<string>("ba", "ba");
        }
    }
}
