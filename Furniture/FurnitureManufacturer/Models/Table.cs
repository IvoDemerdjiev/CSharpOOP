namespace FurnitureManufacturer.Models
{
    using Interfaces;
    using System;

    public class Table : Furniture, ITable
    {
        private decimal height;
        private MaterialType materialType;
        private string model;
        private decimal price;

        public Table(string model, MaterialType materialType, decimal price, decimal height, decimal length, decimal width)
        {
            this.Model = model;
            this.MaterialType = materialType;
            this.Price = price;
            this.Height = height;
            this.Length = length;
            this.Width = width;
        }

        public decimal Area
        {
            get
            {
                return (this.Length * this.Width);
            }
        }

        public decimal Length { get; set; }

        public decimal Width { get; set; }

        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Length: {5}, Width: {6}, Area: {7}", this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.Length, this.Width, this.Area);
        }

    }
}
