using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise05a
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            //IsContains5(arr);

        }

        static void Input(int [] arr)
        {
           for (int i = 0;i<arr.Length;i++)
           {
               Console.Write(" enter value arr{0}=", i);
               arr[i] = int.Parse(Console.ReadLine());

              
               }
           }
        static bool Iscontains5(int[] arr)
        {
            for(int i= 0 ; i)
        }
           
    }
}
