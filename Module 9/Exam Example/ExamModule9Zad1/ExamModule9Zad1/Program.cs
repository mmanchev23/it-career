using System;

namespace ExamModule9Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateCoupons(n));
            Console.WriteLine(CalculateCouponsGreedy(n));
        }

        // Basic Solution - faster - O(log n)
        public static int CalculateCoupons(int n)
        {
            int coupon_value = n * 20;
            int coupons = 0;

            while (coupon_value != 0)
            {
                if (coupon_value % 100 == 0)
                {
                    coupon_value -= 100;
                }
                else
                {
                    coupon_value -= 20;
                }

                coupons++;
            }

            return coupons;
        }

        // Greedy Solution - slower - O(n)
        public static int CalculateCouponsGreedy(int n)
        {
            int coupon_value = n * 20;
            int[] coupons = { 100, 20 };
            int coupons_count = 0;
            int i = 0;

            while (coupon_value != 0)
            {
                while (coupon_value - coupons[i] >= 0)
                {
                    coupon_value -= coupons[i];
                    coupons_count++;
                }

                i++;
            }

            return coupons_count;
        }
    }
}
