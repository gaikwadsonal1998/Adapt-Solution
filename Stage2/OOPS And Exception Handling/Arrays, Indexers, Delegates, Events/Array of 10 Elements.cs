using System;

namespace LearnCsharp
{

	class SingleDimArray
	{
	    public static void Main(string[] args) 
	    {

            int[] iArray=new int[10];
            int j = 0 ;
	        

			//Add your code 
			for( int i = 1 ; i <= 10 ; i++ ){
			    iArray[j] = 2 * i ;
			    j++;
			}


            foreach (var item in iArray)
            {
                Console.WriteLine((item)); 
            }
            
        }

	}

}