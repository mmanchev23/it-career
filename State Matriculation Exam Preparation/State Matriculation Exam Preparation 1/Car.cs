using System;

namespace State_Matriculation_Exam_Preparation_1
{
    class Car
    {
        private string brand;
        private int year;
        private int mileage;
        private int value;

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

        public int Value
        {
            get => this.value;
            set => this.value = value > 0 ? value : throw new ArgumentException("The Value can not be less than 0!");
        }

        public Car(string brand, int year, int mileage, int value)
        {
            this.Brand = brand;
            this.Year = year;
            this.Mileage = mileage;
            this.Value = value;
        }

        public virtual double Price()
        {
            if (2021 - this.Year <= 3)
            {
                return Math.Round(this.Value * 0.8, 2);
            }
            else if (4 <= 2021 - this.Year && 2021 - this.Year <= 6)
            {
                return Math.Round(this.Value * 0.6, 2);
            }
            else if (7 <= 2021 - this.Year)
            {
                return Math.Round(this.Value * 0.3, 2);
            }

            return this.Value;
        }

        public override string ToString()
        {
            return $"{this.Brand}: {this.Mileage} km, {this.Price()}";
        }
    }
}
