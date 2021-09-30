using System;

namespace Exam_Preparation
{
    class Car
    {
        private string brand;
        private int year;
        private int mileage;
        private double value;

        public string Brand
        {
            get => this.brand;
            set => this.brand = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Invalid Brand Information!");
        }

        public int Year
        {
            get => this.year;
            set => this.year = value > 0 ? value : throw new ArgumentException("The Year can not be less than 0!");
        }

        public int Mileage
        {
            get => this.mileage;
            set => this.mileage = value > 0 ? value : throw new ArgumentException("The Mile-age can not be less than 0!");
        }

        public double Value
        {
            get => this.value;
            set => this.value = value > 0 ? value : throw new ArgumentException("The Value can not be less than 0!");
        }

        public Car(string brand, int year, int mileage, double value)
        {
            this.Brand = brand;
            this.Year = year;
            this.Mileage = mileage;
            this.Value = value;
        }

        public virtual double Price()
        {
            if (DateTime.Now.Year - this.Year <= 3)
            {
                return Math.Round(this.Value * 0.8, 2);
            }
            else if (4 <= DateTime.Now.Year - this.Year && DateTime.Now.Year - this.Year <= 6)
            {
                return Math.Round(this.Value * 0.6, 2);
            }
            else if (7 <= DateTime.Now.Year - this.Year)
            {
                return Math.Round(this.Value * 0.3, 2);
            }

            return this.Value;
        }

        public override string ToString()
        {
            return $"{this.Brand}: {this.Mileage} km, {this.Price():F2}";
        }
    }
}
