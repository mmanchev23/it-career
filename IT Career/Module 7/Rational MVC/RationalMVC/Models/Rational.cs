using System;

namespace RationalMVC.Models
{
    public class Rational
    {
        private int num;
        private int denum;

        public int Num
        {
            get => this.num;
            set => this.num = value;
        }

        public int Denum
        {
            get => this.denum;
            set => this.denum = value != 0 ? value : throw new DivideByZeroException("The Denominator can not be equal to zero.\nYou can not devide be zero!");
        }

        public Rational(int num, int denum)
        {
            if (denum < 0)
            {
                num = -num;
                denum = -denum;
            }

            int greatestCommonDivisor = GreatestCommonDivisor(Math.Abs(num), Math.Abs(denum));

            this.Num = num / greatestCommonDivisor;
            this.Denum = denum / greatestCommonDivisor;
        }

        public Rational() : this(1, 1) { }

        private int GreatestCommonDivisor(int a, int b) => b == 0 ? Math.Abs(a) : GreatestCommonDivisor(Math.Abs(b), Math.Abs(a) % Math.Abs(b));

        public Rational Plus(Rational a) => new Rational((this.Num * a.Denum) + (a.Num * this.Denum), (this.Denum * a.Denum));

        public static Rational operator +(Rational r1, Rational r2) => r1.Plus(r2);

        public Rational Minus(Rational a) => new Rational((this.Num * a.Denum) - (a.Num * this.Denum), (this.Denum * a.Denum));

        public static Rational operator -(Rational r1, Rational r2) => r1.Minus(r2);

        public Rational Multiply(Rational a) => new Rational((this.Num * a.Num), (this.Denum * a.Denum));

        public static Rational operator *(Rational r1, Rational r2) => r1.Multiply(r2);

        public Rational Devide(Rational a)
        {
            int denominator = a.Num * this.Denum;

            if (denominator == 0) throw new DivideByZeroException("The Denominator can not be equal to zero.\nYou can not devide be zero!");

            return new Rational((this.Num * a.Denum), denominator);
        }

        public static Rational operator /(Rational r1, Rational r2) => r1.Devide(r2);

        public static Rational Compare(Rational r1, Rational r2)
        {
            int a = r1.Num;
            int b = r1.Denum;
            int c = r2.Num;
            int d = r2.Denum;

            int result = a * d - b * c;

            return (result > 0) ? r1 : r2;
        }

        public override string ToString() => $"{this.Num} / {this.Denum}";

        ~Rational() { }
    }
}
