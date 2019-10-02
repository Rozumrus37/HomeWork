sing System;

public class Program
{
public static void Main()
{
Begin30();
}
static void Begin4() {
int d = 5;
double L = Math.PI * d;
Console.WriteLine(L);
}
static void Begin5() {
int a = 5;
int V  = a*a*a;
int S = a*a*6;
Console.WriteLine(V + " " + S);
}
static void Begin6() {
int a = 1, b = 2, c = 3;
int V = a*b*c;
int S = 2*(a*b + a*c+b*c);
Console.WriteLine(V + " " + S);
}
static void Begin7() {
int R = 2;
double L = 2*Math.PI*R;
double S = Math.PI * (R*R);
Console.WriteLine(L + " " + S);
}
static void Begin8() {
int a = 1, b = 2;
double res = (a + b)/2.0;
Console.WriteLine(res);
}
static void Begin9() {
int a = 2, b = 50;
double res = Math.Sqrt(a*b);
Console.WriteLine(res);
}
static void Begin10() {
double a = 1, b = 2;
double S = a + b;
double D = a - b;
double Mul = (a*a)*(b*b);
double Dev = (a*a)/(b*b);
Console.WriteLine(S + " " + D + " " + Mul + " " + Dev);
}
static void Begin11() {
double a = 1, b = 2;
double S = a + b;
double D = a - b;
double M = a*b;
double ChM = Math.Abs(a)/Math.Abs(b);
Console.WriteLine(S + " " + D + " " + M + " " + ChM);
}
static void Begin12() {
int a = 4, b = 3;
double c = Math.Sqrt(a*a + b*b);
double P = a + b + c;
Console.WriteLine(c + " " + P);
}
static void Begin13() {
int r1 = 4, r2 = 3;
double S1 = Math.PI * (r1*r1);
double S2 = Math.PI * (r2*r2);
double S3 = S1-S2;
Console.WriteLine(S1 + " " + S2 + " " + S3);
}
static void Begin14() {
int L = 1;
double R = L / (2*Math.PI);
double S = Math.PI * (R*R);
Console.WriteLine(R + " " + S);
}
static void Begin15() {
double S = 37;
double L = 2*Math.PI*Math.Sqrt(S/Math.PI);
double D = 2*Math.Sqrt(S/Math.PI);
Console.WriteLine(D + " " + L);
}
static void Begin16() {
int x1 = 1, x2 =2;
Console.WriteLine(Math.Abs(x1 - x2));
}
static void Begin17() {
int A = 2, B = 4, C = 6;
int AC = Math.Abs(A - C);
int BC = Math.Abs(B - C);
int sum = AC + BC;
Console.WriteLine(AC + " " + BC + " " + sum);
}
static void Begin18() {
int A = 2, B = 4, C = 3;
int AC = Math.Abs(A - C);
int BC = Math.Abs(B - C);
int sum = AC * BC;
Console.WriteLine(sum);
}
static void Begin19() {
int x1 = 1, y1 = 2, x2 = 3, y2 = 4;
double AB = Math.Sqrt((y1 - y2)*(y1 - y2));
double BC = Math.Sqrt((x1 - x2)*(x1 - x2));
double P = 2*AB + 2*BC;
double S = AB*BC;
Console.WriteLine(P + " " + S);
}
static void Begin20() {
int xa = 1, ya = 2, xb = 3, yb = 1;
double AB = Math.Sqrt((xa - xb)*(xa - xb) + (ya - yb)*(ya - yb));
Console.WriteLine(AB);
}
static void Begin21() {
int x1 = 1, y1 = 2, x2 = 3, y2 = 4, x3 = 5, y3 = 6;
double AB = Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2));
double BC = Math.Sqrt((x3 - x2)*(x3 - x2) + (y3 - y2)*(y3 - y2));
double AC = Math.Sqrt((x1 - x3)*(x1 - x3) + (y1 - y3)*(y1 - y3));
double P = AB + BC + AC;
double p = P/2.0;
double S = Math.Sqrt(p*(p-AB)*(p-BC)*(p-AC));
Console.WriteLine(P + " " + S);
}
static void Begin22() {
int A = 1, B = 2;
int t = A;
A = B;
B = t;
Console.WriteLine(A + " " + B);
}
static void Begin23() {
int A = 1, B = 2, C = 3;
   B = A;
C = B;
A = C;
Console.WriteLine(A + " " + B + " " + C);
}
static void Begin24() {
int A = 1, B = 2, C = 3;
   C = A;
   B = C;
   A = B;
Console.WriteLine(A + " " + B + " " + C);
}
static void Begin25() {
int x = 1;
double y = 3*Math.Pow(x, 6) - 6*(x*x) - 7;
Console.WriteLine(y);
}
static void Begin26() {
int x = 1;
double y = 4*Math.Pow(x-3, 6) - 7 * Math.Pow(x-3, 3) + 2;
Console.WriteLine(y);
}
static void Begin27() {
int A = 2;
int t = A*A;
Console.WriteLine(t);
t *= A*A;
Console.WriteLine(t);
t *= A*A;
Console.WriteLine(t);
}
static void Begin28() {
int A = 2;
int t = A*A, t1 = A;
Console.WriteLine(t);
t *= t1;
Console.WriteLine(t);
t *= A*A;
Console.WriteLine(t);
t1 = t;
t *= t;
Console.WriteLine(t);
t *= t1;
Console.WriteLine(t);
}
static void Begin29() {
double a = 16;
double r = (a*Math.PI)/180.0;
Console.WriteLine(r);
}
static void Begin30() {
double r = 0.4;
double res = (r*180)/Math.PI;
Console.WriteLine(res);
}
}