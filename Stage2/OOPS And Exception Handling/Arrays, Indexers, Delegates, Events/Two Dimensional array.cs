using System;

namespace LearnCsharp
{
   
	class TwoDimArray
	{
	    public static void Main(string[] args)
	    {
			//Update the code below
			
            int [,]iMatrix;
            iMatrix = new int[3,2];
int i,j;
            iMatrix[0, 0] = int.Parse(Console.ReadLine());
            iMatrix[0, 1] = int.Parse(Console.ReadLine());
            iMatrix[1, 0] = int.Parse(Console.ReadLine());
            iMatrix[1, 1] = int.Parse(Console.ReadLine());

            int iRowSum;
           int [] c=new int[2];
            iRowSum = 0;
            for (i=0;i<=1;i++)
        
            {c[i]=0;
                iRowSum=0;
            
                for(j=0;j<=1;j++)
                {
                    Console.Write(iMatrix[i,j]+"|");
                iRowSum =iRowSum+iMatrix[i,j];
                c[i]=c[i]+iMatrix[j,i];
                }
                Console.Write(iRowSum);
                Console.WriteLine();
            }
            
            Console.WriteLine( c[0]+"|"+c[1]+"|"+(c[0]+c[1]) );
        }
    }
}