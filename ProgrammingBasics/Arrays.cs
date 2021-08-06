using System;
namespace ProgrammingBasics
{
    public class Arrays
    {
        
            internal static void SingleDimensional(){
            /*int[] marks; // declaration
            marks = new int[5]; // initialization
            marks[0]=67; // addinig elements
            marks[3]=85;*/
            /*for (int i = 0; i < marks.Length; i++)
            {
               Console.WriteLine(marks[i]);
            }*/
            //int[] marks=new int[]{67,80,54,66,98};
            int[] marks={67,80,54,66,98};
            Console.WriteLine("This array has - {0} elements.",marks.Length);
            Console.WriteLine("This array's rank - {0}.",marks.Rank);
            Array.Sort(marks);
            Array.Reverse(marks);
            foreach(int mark in marks){
                Console.Write(mark + " ");
            }
        }
            /*internal static void MultiDimensional()
            {

            
            }*/
    }
}