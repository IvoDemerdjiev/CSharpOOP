namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using System;

    public class Chair : Furniture, IChair , IFurniture
    {

        public Chair(string model, MaterialType materialType, decimal price, decimal height, int numberOfLegs)
        {
            this.Model = model;
            this.MaterialType = materialType;
            this.Price = price;
            this.Height = height;
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs { get; protected set; }
       
    }
}
