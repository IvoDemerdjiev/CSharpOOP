namespace GSM
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GSM
    {
        public static readonly GSM IPhone4S = new GSM(
          "iPhone 4S",
          "Apple",
          500,
          "Steve",
          new Battery(BatteryType.Li_Ion, 48, 24),
          new Display(4.8, 2000000));

        private string model;
        private string manufacturer;
        private double? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();

        public GSM(string model, string manufacturer)
           : this(model, manufacturer, null, null, new Battery(), new Display())
        {
        }

        public GSM(string model, string manufacturer, double? price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Model is mandatory ");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Manufacturer is mandatory ");
                }

                this.manufacturer = value;
            }
        }

        public double? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price must be positive number");
                }

                this.price = value;
            }
        }
        public string Owner { get; set; }

        public Display Display { get; set; }

        public Battery Battery { get; set; }

        public string CallHistory
        {
            get
            {
                if (callHistory.Count == 0)
                {
                    return "Call history is empty!";
                }
                else
                {
                    var callInfo = new StringBuilder();

                    for (int i = 1; i <= callHistory.Count; i++)
                    {
                        callInfo.AppendFormat("{0}. {1}\n", i, this.callHistory[i - 1]);
                    }

                    return callInfo.ToString();
                }
            }
        }

        public override string ToString()
        {
            var information = new StringBuilder();

            information.AppendFormat("Model: {0} ", this.model);
            information.AppendFormat("Manufacturer: {0} ", this.manufacturer);

            if (this.price != null)
            {
                information.AppendFormat("Price: {0} ", this.price);
            }

            if (this.owner != null)
            {
                information.AppendFormat("Owner: {0} ", this.owner);
            }

            information.AppendFormat("Battery: {0}\n", this.battery);
            information.AppendFormat("Display: {0}\n", this.display);

            return information.ToString();
        }

        public void Info()
        {
            Console.WriteLine(this.ToString());
        }

        public void AddCall(Call Number)
        {
            this.callHistory.Add(Number);
        }

        public void DeleteCall(Call Number)
        {
            this.callHistory.Remove(Number);
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        public decimal GetPrice(decimal pricePerMinute)
        {
            decimal total = 0;

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                total += this.callHistory[i].Duration;
            }

            decimal price = total * (pricePerMinute / 60);

            return price;
        }

        public void RemoveLongestCall()
        {
            int maxDurationIndex = 0;
            decimal maxDuration = 0;

            if (this.callHistory.Count > 0)
            {
                for (int i = 0; i < this.callHistory.Count; i++)
                {
                    if (this.callHistory[i].Duration > maxDuration)
                    {
                        maxDuration = this.callHistory[i].Duration;
                        maxDurationIndex = i;
                    }
                }

                this.callHistory.RemoveAt(maxDurationIndex);
            }
        }
        static void Main(string[] args)
        {
              private GSM[] GSMCollection = {
            new GSM("Iphone 70", "Apple", 500, "Pesho", new Battery(BatteryType.NiCd, 72, 48), new Display(5.5, 2300000)),
            new GSM("Iphone 60", "Apple", 400, "Ivan", new Battery(BatteryType.Li_Ion, 70, 45), new Display(5.8, 32000000)),
            new GSM("Iphone 3","Apple")
        public void DisplayInformation()
        {
            foreach (var gsm in GSMCollection)
            {
                gsm.Info();
            }
            GSM.IPhone4S.Info();
        }
    }
