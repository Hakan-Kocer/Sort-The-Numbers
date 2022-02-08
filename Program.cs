using System;

namespace Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayOfInput=new int[] {4, 13, 8, 9, 7, 1, 6};
            int lenght=ArrayOfInput.Length;
            int[] NewArray=new int[lenght];

            Array.Sort(ArrayOfInput);
            Array.Reverse(ArrayOfInput);

            int counter=0;
            for(int i=0;i<lenght;i++)
            {
                if(i%2==0)
                {
                    NewArray[counter]=ArrayOfInput[i];
                }
                else{
                    NewArray[lenght-(counter+1)]=ArrayOfInput[i];
                    counter+=1;
                }
            }
            DisplayValues(NewArray);
        }

        public static void DisplayValues(int[] arr)
   {
      for ( int i=0;i<arr.Length;i++ )  {
         Console.WriteLine( "   [{0}] : {1}", i, arr[i] );
      }
      Console.WriteLine();
   }
    }
}
