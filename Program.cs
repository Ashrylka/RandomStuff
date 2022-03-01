using System;

class Program
{
    public static void Main(string[] args)
    {
        bool? isMax1 = null;
        string input;
        Console.WriteLine("Min or Max?");
        do{
        string minOrMax= Console.ReadLine();
        if(minOrMax == "Max"|| minOrMax == "max") { 
            isMax1 = true;}
        else if(minOrMax == "Min"|| minOrMax == "min"){
            isMax1 = false;}
        else { 
            Console.WriteLine("Invalid entry. Min or Max?"); 
        }
        	}while (isMax1==null);      
        bool isMax = isMax1 ?? false;        
        int a,b,c;
        Console.WriteLine("Enter number #1");
        a= CheckInputInt(Console.ReadLine(),"#1");
        Console.WriteLine("Enter number #2");
        b= CheckInputInt(Console.ReadLine(),"#2");
        Console.WriteLine("Enter number #3");
        c= CheckInputInt(Console.ReadLine(),"#3");
        Console.WriteLine(MinMax(a, b, c, isMax));
    }
    public static dynamic CheckInputInt(string input, string numX)
    {
         int result;
         while (!int.TryParse(input, out result))
               {
                    Console.WriteLine("Invalid entry. Enter number "+ numX);
                    input = Console.ReadLine();
               }
         return result;
    }
    public static dynamic MinMax(int a, int b, int c, bool isMax)
    {
        if (isMax){
            return("Max = " + MyMax(a,b,c));
        }
        else{
            return("Min = " + MyMin(a,b,c));
        }

    }
    public static int MyMax(int a, int b, int c)
    {
        int max;
        if (a > b)
        {
            if (a > c)
            {
                max = a;
            }
            else
            {
                max = c;
            }
        }
        else
        {
            if (b > c)
            {
                max = b;
            }
            else
            {
                max = c;
            }
        }
        return max;
    }
    public static int MyMin(int a, int b, int c)
    {
        int min;
        if (a < b)
        {
            if (a < c)
            {
                min = a;
            }
            else
            {
                min = c;
            }
        }
        else
        {
            if (b < c)
            {
                min = b;
            }
            else
            {
                min = c;
            }
        }
        return min;
    }
}