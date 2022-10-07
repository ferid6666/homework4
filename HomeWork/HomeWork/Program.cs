using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {





            Console.WriteLine(Exercise1(63));

            Console.WriteLine(Exercise2(2, 14));

            Console.WriteLine(Exercise3(10, 20));

            Console.WriteLine(Exercise4(5, 10));

            Console.WriteLine(Exercise5(new int[] { 5, 7, 23, 45, 67 }));

            Console.WriteLine(Exercise6(new int[] { 5, 7, 23, 45, 67 }));

            Console.WriteLine(Exercise7(16));

            Console.WriteLine(Exercise8(256));

            Console.WriteLine(Exercise9(new int[] { 5, 7, 23, 45, 67 }));

            Console.WriteLine(Exercise10(new int[] { 5, 7, 23, 45, 67, 84, 98 }));
        }




        #region  exercise1:  Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.
        public static bool Exercise1(int n)
        {
            if (n % 21 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion


        #region exercise2 :  n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.

        public static string Exercise2(int n, int m)
        {

            int S = 0;

            if (n % 2 == 0 && m % 2 == 0)
            {
                S = n + m;

                return $"{S}";
            }
            else
            {
                return "Sehv ededleri daxil etmisiniz";
            }

        }


        #endregion


        #region exercise3 : Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.

        public static int Exercise3(int n, int m)
        {
            int C = 0;
            if (n < m)
            {
                for (int i = n; i <= m; i++)
                {
                    if (i % 2 == 1)
                    {
                        C++;
                    }
                }
            }
            return C;
        }

        #endregion


        #region exercise4 :Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.

        public static int Exercise4(int n, int m)
        {
            int S = 0;

            if (n < m)
            {
                for (int i = n; i <= m; i++)
                {
                    if (i % 2 == 1)
                    {
                        S += i;
                    }
                }
            }
            return S;
        }

        #endregion


        #region exercise5 :Verilmish arrayin icindeki tek ededlerin cemini tapin.


        public static int Exercise5(int[] arr)
        {
            int S = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    S += arr[i];
                }
            }
            return S;
        }

        #endregion


        #region exercise6 : Verilmish arrayin icindeki cut ededlerin sayini tapin.

        public static int Exercise6(int[] arr)
        {
            int C = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    C++;
                }
            }
            return C;
        }

        #endregion


        #region exercise7 : Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

        public static string Exercise7(int n)
        {

            int C = 0;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    C++;
                }
            }

            if (C == 0)
            {
                return "Sade ededdir";
            }
            else
            {
                return "Murekkeb ededdir";
            }
        }

        #endregion


        #region exercise8: n ededi gelir. 2-ni hansisa quvvete yukseltdikde n-in alinan cavaba beraber olub-olmamasını tapın.Meselen: Cavablar ola biler:2,4,8,16,32 ve s. Yeni n bele ededler olmalidir.

        public static string Exercise8(int n)
        {

            int a = 2;

            if (n > 1)
            {
                while (a <= n)
                {
                    a *= 2;
                }
            }
            if (a / 2 == n)
            {
                return n + " ededi 2 nin quvvetidir";
            }
            else
            {
                return n + " ededi 2 nin quvveti deyil";
            }

        }

        #endregion


        #region exercise9 :Verilmish arrayin-in elementlerinin icinden 1-20 arasinda olanlarinin hasilini tapmaq.Mes ([1,3,55,6,33], cavab : 18)

        public static int Exercise9(int[] arr)
        {

            int M = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 1 && arr[i] < 20)
                {
                    M *= arr[i];
                }
            }

            return M;
        }


        #endregion


        #region exercise10: Verilmish arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.


        public static int Exercise10(int[] arr)
        {
            int S = 0;

            int M = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    S += arr[i];
                }
            }

            M = S * S;

            return M;
        }
        #endregion
    }
}

