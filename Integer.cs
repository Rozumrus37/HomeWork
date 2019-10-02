using System;

public class Test
{
    public static void Main()
    {
        Integer18();
    }
   
    static void Integer1() {
        int a = 1000;
        int res = a / 100;
        Console.WriteLine(res);
    }
   
    static void Integer2() {
        int M = 10;
        int res = M / 1000;
        Console.WriteLine(res);
    }
   
    static void Integer3() {
        int size = 1025;
        int res = size / 1024;
        Console.WriteLine(res);
    }
   
    static void Integer4() {
       int A = 100, B = 10;
       int res = A / B;
       Console.WriteLine(res);
    }
   
    static void Integer5() {
       int A = 100, B = 10;
       int res = A % B;
       Console.WriteLine(res);
    }
   
    static void Integer6()
    {
       int A = 12;
       int right = A % 10;
       int left = A / 10;
       Console.WriteLine(left + " " + right);
    }
   
    static void Integer7() {
       int A = 12;
       int right = A % 10;
       int left = A / 10;
       int sum = right + left;
       int mul = right * left;
       Console.WriteLine(sum + " " + mul);
    }
   
    static void Integer8() {
       int A = 12;
       int right = A % 10;
       int left = A / 10;
       Console.WriteLine(right +""+ left);
    }
   
    static void Integer9()
    {
       int A = 123;
       int res = A / 100;
       Console.WriteLine(res);
    }
   
    static void Integer10() {
       int A = 123;
       int last = A % 10;
       int mid = ((A - last) / 10)%10;
       Console.WriteLine(last + " " + mid);
    }
   
    static void Integer11() {
       int A = 124;
       int sum =  A % 10  + ((A - A%10) / 10)%10 + A / 100;
       int mul = A % 10 * (((A - A % 10) / 10) % 10) * (A / 100);
       Console.WriteLine(sum + " " + mul);
    }
   
    static void Integer12() {
       int A = 124;
       int first = A / 100;
       int last = A % 10;
       int mid = ((A - last) / 10) % 10;
       Console.WriteLine(last + "" + mid + "" + first);
    }
   
    static void Integer13() {
       int A = 124;
       int first = A / 100;
       int last = A % 10;
       int mid = ((A - last) / 10) % 10;
       Console.WriteLine(mid + "" + last + "" + first);
    }
   
    static void Integer14() {
       int A = 124;
       int first = A / 100;
       int last = A % 10;
       int mid = ((A - last) / 10) % 10;
       Console.WriteLine(last + "" + first + "" + mid);
    }
   
    static void Integer15() {
       int A = 124;
       int first = A / 100;
       int last = A % 10;
       int mid = ((A - last) / 10) % 10;
       Console.WriteLine(mid + "" + first + "" + last);
    }
   
    static void Integer16() {
       int A = 124;
       int first = A / 100;
       int last = A % 10;
       int mid = ((A - last) / 10) % 10;
       Console.WriteLine(first + "" + last + "" + mid);
    }
   
    static void Integer17()
    {
       int a = 123694;
       int sot = a / 100 % 10;
       Console.WriteLine(sot);
    }
   
    static void Integer18() {
       int a = 123694;
       int sot = a / 1000 % 10;
       Console.WriteLine(sot);
    }
   
    static void Integer19()
    {
       int n = 10503;
       Console.WriteLine(n / 60);
    }
   
    static void Integer20() {
       int n = 10503;
       Console.WriteLine(n / 3600);
    }
   
    static void Integer21() {
       int n = 10503;
       Console.WriteLine(n % 60);
    }
   
    static void Integer22() {
       int n = 10503;
       Console.WriteLine(n % 3600);
    }
   
    static void Integer23() {
       int n = 10503;
       Console.WriteLine(n % 3600/60);
    }
   
    static void Integer24()
    {
       int k = 10;
       Console.WriteLine(k % 7);
    }
   
    static void Integer25() {
       int k = 10;
       Console.WriteLine((k+1) % 7);
    }
   
    static void Integer26() {
       int k = 10;
       Console.WriteLine((k+2) % 7);
    }
   
    static void Integer27() {
       int k = 10;
       Console.WriteLine((k+3) % 7);
    }
   
    static void Integer28() {
       int k = 10, n=11;
       Console.WriteLine((k + n-1) % 7);
    }
   
    static void Integer29()
    {
       int A = 3, B = 4, C = 2;
       double n = (A / C) * (B / C);
       Console.WriteLine(n);
       n *= Math.Sqrt(C);
       n -= A * B;
       Console.WriteLine(n);
    }
   
    static void Integer30()
    {
       int n = 10;
       Console.WriteLine((n-1)/100+1);
    }
   
   
}