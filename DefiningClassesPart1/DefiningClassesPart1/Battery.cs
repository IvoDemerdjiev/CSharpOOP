namespace GSM
{
    using System;
    using System.Text;

    public enum BatteryType
    {
        Li_Ion,
        NiMH,
        NiCd
    }

   public class Battery
    {
       private BatteryType? model;
       private double? hoursIdle;
       private double? hoursTalk;

        public Battery()
         : this(null, null, null)
        {
        }

        public Battery(BatteryType? model, double? hoursIdle, double? hoursTalk)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        public BatteryType? Model { get; set; }


        public double? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            set
            {
                if (this.hoursIdle <= 0)
                {
                    throw new ArgumentException("Houre idle must be a positive number");
                }
                    this.hoursIdle = value;
            }
        }

        public double? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            set
            {
                if (this.hoursTalk <= 0)
                {
                    throw new ArgumentException("Hours talk must be a positive number");
                }
                    this.hoursIdle = value;
            }
        }

        public override string ToString()
        {
            var batteryInfo = new StringBuilder();

            batteryInfo.AppendFormat("Battery type: {0}", this.model);

            if (this.hoursIdle != null)
            {
                batteryInfo.AppendFormat(", Hours idle: {0}", this.hoursIdle);
            }

            if (this.hoursTalk != null)
            {
                batteryInfo.AppendFormat(", Hours talk: {0}", this.hoursTalk);
            }

            return batteryInfo.ToString();
        }
    }
}
