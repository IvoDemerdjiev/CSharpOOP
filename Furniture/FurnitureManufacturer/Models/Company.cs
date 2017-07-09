namespace FurnitureManufacturer.Models
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Company : ICompany
    {
        private string name;

        private string registrationNumber;

        private ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }
        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return this.furnitures;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length<5)
                {
                    throw new ArgumentOutOfRangeException("•	Name cannot be empty, null or with less than 5 symbols.");
                }
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            set
            {
                if (value == null || value.Length!=10)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public string Catalog()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(string.Format(
                "{0} - {1} - {2} {3}",
                    this.Name,
                    this.RegistrationNumber,
                    this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                    this.Furnitures.Count != 1 ? "furnitures" : "furniture"
                    ));
            return stringBuilder.ToString();      
          

        }

        public IFurniture Find(string model)
        {
            return this.furnitures.FirstOrDefault(f => f.Model.ToLower() == model.ToLower());
        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }
    }
}
