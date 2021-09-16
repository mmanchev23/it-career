using System;

namespace State_Matriculation_Exam_Preparation_1
{
    class Truck : Car
    {
        private int tonnage;

        public int Tonnage
        {
            get => this.tonnage;
            set => this.tonnage = value > 0 ? value : throw new ArgumentException("The Tonnage can not be less than 0!");
        }

        public Truck(string brand, int year, int mileage, int value, int tonnage) : base(brand, year, mileage, value)
        {
            this.Tonnage = tonnage;
        }

        public override double Price()
        {
            if (2021 - this.Year <= 5)
            {
                return 0;
            }
            else if (2021 - this.Year > 5 && this.Tonnage <= 5)
            {
                return Math.Round(this.Value * 0.3, 2);
            }
            else if (2021 - this.Year > 5 && (5 <= this.Tonnage && this.Tonnage <= 10))
            {
                return Math.Round(this.Value * 0.6, 2);
            }
            else if (2021 - this.Year > 5 && this.Tonnage > 10)
            {
                return Math.Round(this.Value * 0.8, 2);
            }

            return this.Value;
        }

        public override string ToString()
        {
            return $"{this.Brand}: {this.Mileage} km, {this.Price()}";
        }
    }
}
