
using System;
 
namespace LearnCsharp
{
	class FindMaxMinAge{
	    public static void Main(string[] args) {
	        
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr= new int[n];
       
        
        if ( n < 1 || n > 20 )
        {
            Console.WriteLine("INVALID_INPUT");
        }
        else
        {
			 for(int i=0;i<n;i++)
        {
            arr[i]= Convert.ToInt32(Console.ReadLine());
        }
         int min = arr[0];
         int max = arr[0];
			
            for(int i=0; i < n; i ++){
           if (min > arr[i]) 
              min = arr[i];
             if (max < arr[i])
            max= arr[i];  
            }
//student code goes here
            Console.WriteLine("MIN=" + min);

            
       //student code goes here     

            Console.WriteLine("MAX=" + max);
        }
        
	    }
	}
}