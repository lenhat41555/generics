using System;

namespace generics
{
      class Generic<T>
    {
        
       public void Generics<n>(n x,n y)
        {
           if (x.Equals(y))
            {

                Console.WriteLine($"{x} bang {y}");
            }
            else
            {

                Console.WriteLine($"{x} khong bang {y}");
            }
        }
    }
}