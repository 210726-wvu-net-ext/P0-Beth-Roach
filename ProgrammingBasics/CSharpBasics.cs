using System;

Namespace ProgrammingBasics
{
    class Program
    {
    static void Main(string[] args)
    {
        long a = 10;
        //int b = (long) a; // explicit conversion
        //int b = long.Parse(a); //explicit conversion
        int b = Convert.ToInt64(a); //explicit conversion
    }
    }
}