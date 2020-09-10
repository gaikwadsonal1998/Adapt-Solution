using System;

namespace LearnCsharp
{

	class TrapRunTimeErrors
	{
	    public static void Main(string[] args)
	    {
			//Update the code below
			int check = 0;
            int[] iTemp = new int[10];
            for(int i = 0 ; i < 6 ; i ++){
                var str = Console.ReadLine() ;
                int num ;
                bool parseSuccess = int.TryParse(str, out num);
                if(parseSuccess){iTemp[i] = num ;}
                else{check = 3 ; break ; } 
                
                if(iTemp[5] != 0){ check = 2 ; break;}
                else{ check = 1 ; }
            }

            int[] iValue;
            iValue = new int[5];
            

            if(check == 1)
            {
                for (int iCount = 0 ; iCount < 5 ; iCount++)
                {
                    iValue[iCount] = iTemp[iCount];    
                }               

                foreach (int iCurItem in iValue)
                {
                    Console.WriteLine(iCurItem);
                }
            }
            else if(check == 2)
            {
                Console.WriteLine("Program tried to access index beyond the array size");
            }
            else
            {
                Console.WriteLine("General Exception");
            }

	    }
	}
}