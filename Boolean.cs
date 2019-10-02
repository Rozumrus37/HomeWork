using System;

public class Test
{
    public static void Main()
    {
        Boolean4();
    }

    static void Boolean1()
    {
        int A = 1;
        Console.WriteLine(A > 0);

    }
    
    static void Boolean2()
    {
        int A = 1;
        Console.WriteLine(A % 2 == 1);
        
    }
    
    static void Boolean3()
    {
        int A = 1;
        Console.WriteLine(A % 2 == 0);
        
    }
    
    static void Boolean4()
    {
        int A = 1, B = 2;
        Console.WriteLine(A >= 2 && B <= 3);

    }
    
    static void Boolean5()
    {
        int A = 1, B = 2;
        Console.WriteLine(A >= 0 && B < -2);
        
    }
    
    static void Boolean6()
    {
        int A = 1, B = 2, C = 4;
        Console.WriteLine(A < B  && B < C);
        
    }
    
    static void Boolean7()
    {
        int A = 1, B = 2, C = 3;
        Console.WriteLine(A <= B && B <= C);

    }
    
    static void Boolean8()
    {
        int A = 1, B = 2;
        Console.WriteLine(A % 2 == 1 && B % 2 == 1);
        
    }
    
    static void Boolean9()
    {
        int A = 1, B = 2;
        Console.WriteLine(A % 2 == 1 || B % 2 == 1);
        
    }
    
    static void Boolean10()
    {
        int A = 1, B = 2;
        Console.WriteLine((A % 2 == 1 && B % 2 == 0) || (A % 2 == 0 && B %  2 == 1));
        
    }
