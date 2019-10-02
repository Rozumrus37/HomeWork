using System;

namespace ConsoleApplication3
{
    internal class Program
    {
        public static void Main(string[] args) => If13();

        static void If1()
        {
            int a = 10;
            if (a > 0) a++;
            Console.WriteLine(a);
        }
        static void If2()
        {
            int a = 10;
            if (a > 0) a++;
            else a -= 2;
            Console.WriteLine(a);
        }
        static void If3()
        {
            int a = 10;
            if (a > 0) a++;
            else if (a < 0) a -= 2;
            else a = 10;
            Console.WriteLine(a);
        }
        static void If4()
        {
            int a = 1, b = -2, c = 3, cnt = 0;
            if (a > 0) cnt++;
            if (b > 0) cnt++;
            if (c > 0) cnt++;
            Console.WriteLine(cnt);

        }
        static void If5()
        {
            int a = 1, b = -2, c = 3, cntp = 0, cntn = 0;
            if (a > 0) cntp++;
            else cntn++;
            if (b > 0) cntp++;
            else cntn++;
            if (c > 0) cntp++;
            else cntn++;
            Console.WriteLine(cntp + " " + cntn);
        }
        static void If6()
        {
            int maxx, a = 1, b = 2;
            if (a >= b) maxx = a;
            else maxx = b;
            Console.WriteLine(maxx);
        }
        static void If7()
        {
            int mini, a = 2, b = 1;
            if (a <= b) mini = 0;
            else mini = 1;
            Console.WriteLine(mini);
        }

        static void If8()
        {
            int a = 1, b = 2;
            if (a >= b)
            {
                Console.WriteLine(a + " " + b);
            }
            else Console.WriteLine(b + " " + a);
        }

        static void If9()
        {
            int a = 10, b = 5, t;
            if (a >= b)
            {
                t = a;
                a = b;
                b = t;
                
            }
            Console.WriteLine(a + " " + b);
        }
        static void If10()
        {
            int a = 10, b = 5, t;
            if (a != b)
            {
                t = a;
                a += b;
                b += t;

            }
            else
            {
                a = 0;
                b = 0;
            }
            Console.WriteLine(a + " " + b);
        }
        static void If11()
        {
            int a = 10, b = 5, t;
            if (a != b)
            {
                t = a >= b ? a : b;
                a = t;
                b = t;

            }
            else
            {
                a = 0;
                b = 0;
            }
            Console.WriteLine(a + " " + b);
        }
        static void If12()
        {
            int a = -1, b = -2, c = -1, minn;
            if (a <= b && a <= c) minn = a;
            else if (b <= a && b <= c) minn = b;
            else minn = c;
            Console.WriteLine(minn);
        }
        static void If13()
        {
            int a = 3, b = 3, c = 3, av;
            int t1 = Math.Min(a, Math.Min(b, c));
            int t3 = Math.Max(a, Math.Max(b, c));
            if (a == t1 && b == t3) av = c;
            else if (b == t1 && c == t1) av = a;
            else av = b;
            Console.WriteLine(av);
        }
        static void If14()
        {
            int a = 1, b = 2, c = 3, min1, maxx;
            min1 = Math.Min(a, Math.Min(b, c));
            maxx = Math.Max(a, Math.Max(b, c));
            Console.WriteLine(min1 + " " + maxx);
        }
        static void If15()
        {
            int a = 1, b = 2, c = 3;
            int t1 = Math.Max(a, Math.Max(b, c)), t2;
            if(t1 == a) t2 = Math.Max(b, c);
            else if (t1 == b) t2 = Math.Max(a, c);
            else t2 = c;
            Console.WriteLine(t1+t2);
        }
        static void If16()
        {
            float a = 1, b = 2, c = 3;
            if (a >= b && b >= c)
            {
                a *= 2;
                b *= 2;
                c *= 2;
            }
            else
            {
                a = -a;
                b = -b;
                c = -c;
            }
            Console.WriteLine(a + " " + b + " " + c);
        }
        static void If17()
        {
            float a = 1, b = 2, c = 3;
            if ((a >= b && b >= c) || (a <= b && a <= c))
            {
                a *= 2;
                b *= 2;
                c *= 2;
            }
            else
            {
                a = -a;
                b = -b;
                c = -c;
            }
            Console.WriteLine(a + " " + b + " " + c);
        }
        static void If18()
        {
            int a = 1, b = 2, c = 3, i;
            if (a == b) i = 2;
            else if (a == c) i = 1;
            else i = 0;
            Console.WriteLine(i);
        }
        static void If19()
        {
            int a = 1, b = 2, c = 3, d = 4, i;
            if (a == b && b == c) i = 3;
            else if (a == c && b == c) i = 3;
            else if (b == c && b == d) i = 0;
            else if (a == c && a == d) i = 1;
            else if (a == d && a == c) i = 1;
            else i = 0;
            Console.WriteLine(i);
        }
        static void If20() {
			int a = 1, b = 2, c = 3;
			int ab = Math.Abs(a - b);
			int ac = Math.Abs(a - c);
			Console.WriteLine(ab < ac ? ab : ac);
		}

		static void If21() {
			int x = 1, y = 2;
			int a;
			if (x == 0 && y == 0) a = 0;
			else if (x == 0) a = 2;
			else if (y == 0) a = 1;
			else a = 3;
			Console.WriteLine(a);
		}

		static void If22() {
			int x = 1, y = 2, r;
			if(x * y > 0) {
				if(x > 0) r = 1;
				else r = 3;
			} else {
				if(x > 0) r = 4;
				else r = 2;
			}
			Console.WriteLine(r);
		}

		static void If23() {
			int x1 = 1, y1 = 2, x2 = 3, y2 = 4, x3 = 5, y3 = 6, x4 = 7, y4 = 8;
			int x4 = x1 == x2 ? x3 : (x2 == x3 ? x1 : x2);
			int y4 = y1 == y2 ? y3 : (y2 == y3 ? y1 : y2);
			Console.WriteLine(x4 + " " + y4);
		}

		static void If24() {
			double x = 1;
			double r = x > 0 ? 2 * Math.Sin(x) : 6 - x;
			Console.WriteLine(r);
		}

		static void If25() {
			double x = 4;
			double r = x < -2 || x > 2 ? 2 * x : -3 * x;
			Console.WriteLine(r);
		}

		static void If26() {
			double x = 5;
			double r = x <= 0 ? -x : (x >= 2 ? 4 : x * x);
			Console.WriteLine(r);
		}

		static void If27() {
			double x = 15;
			double r = x < 0 ? 0 : (Convert.ToInt32(Math.Floor(x)) % 2 == 1 ? -1 : 1);
			Console.WriteLine(r);
		}

		static void If28() {
			int n = 23;
			 Console.WriteLine(365 + Convert.ToInt32(n % 4 == 0 && n % 100 != 0 && n % 400 != 0));
		}

		static void If29() {
			int n = 15;
			if(n == 0) 
				 Console.WriteLine("нулевое число");
			else {
				 Console.WriteLine(n > 0 ? "положительное " : "отрицательное ");
				if (n % 2 == 1)  Console.WriteLine("нечетное число");
				 else Console.WriteLine("четное число");
			}
		}

		static void If30() {
			int n = 15;
			if (n % 2 == 1) Console.WriteLine("нечетное ");
			else Console.WriteLine("четное ");
			Console.WriteLine(n / 100 > 0 ? "трехзначное число" : (n / 10 > 0 ? "двухзначное число" : "однозначное число"));
		}
	}
}