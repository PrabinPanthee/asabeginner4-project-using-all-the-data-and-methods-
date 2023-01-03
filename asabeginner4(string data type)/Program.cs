using System;
class Program
{
    static void Main()
    {
        
        int val;
        //parse is a data converter 
        val = int.Parse("1235");
        Console.WriteLine("Value is ",val);
        //equals is a methods that compares two datas gives boolean value 
        flag = int.Equals(1235, 5656);
        if (flag==true) {
            Console.WriteLine("both are equal");
        }
        else
        { Console.WriteLine("both are not equal "); }
    }
}
        

