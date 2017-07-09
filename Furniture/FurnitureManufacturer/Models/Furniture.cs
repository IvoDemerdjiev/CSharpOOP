namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using System;

   public abstract class Furniture : IFurniture
    {
        private string model;

        private decimal price;

        private decimal height;

    

        public MaterialType MaterialType { get; set; }
        public virtual decimal Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be less or equal to 0.00 m.");
                }
            }
        }

        public string Material { get; protected set; }
       

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length<3)
                {
                    throw new ArgumentNullException("Model", "Model cannot be null or less");
                }
                this.model = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be equal or les than 0");
                }
                this.price = value;
            }
        }
    }
}
