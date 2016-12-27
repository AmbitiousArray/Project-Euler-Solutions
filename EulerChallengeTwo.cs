using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Task;

namespace ProjectEuler
{
  public class EulerChallengeTwo
  {
    public static void main(string[] args)
    {
      const int limiter = 4000000;
      int[] sequence = new int[limiter];
      int fibonacci = 1;

      for (int i = 0; i < limiter; i++)
      {
        if (i == 0)
        {
          sequence[i] = fibonacci;
        }
        else if (i == 1)
        {
          sequence[i] = (fibonacci + 1);
        }
        else
        {
          sequence[i] = (sequence[(i-1)] + sequence[(i-2)]);
        }
      }

        int evens = 0;
        foreach (int evenNums in sequence)
        {
          if (evenNums % 2 == 0)
          {
            evens += evenNums;
          }
        }
    }
  }
}
