
using System;

namespace LearnCsharp
{
	class Sortnumbers{
	    public static void Main(string[] args) {

        int n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[n]; // Array declaration

        if ( n < 1 || n > 20)
        {

            Console.WriteLine("INVALID_INPUT");
        }

        else
        {
            //Array elements from console
            for(int i=0; i<n; i++){
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Array.Sort(a);
            
            if(n % 2 ==0){
                foreach(int element in a)
                    Console.Write(element+" ");
            
            }
            else{
                Array.Reverse(a);
                foreach(int element in a)
                    Console.Write(element+" ");
            }

                

            }

          }
	    }
	}

