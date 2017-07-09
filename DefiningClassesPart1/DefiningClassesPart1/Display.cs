namespace GSM
{
    using System;
    using System.Text;

   public class Display
    {
       private double? size;
       private int? numberOfColors;

        public Display()
         : this(null, null)
        {

        }

        public Display(double? size, int? numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        public double? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Size must be a positive number");
                }
                this.size = value;
            }
        }

        public int? NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value<=1)
                {
                    throw new ArgumentException("Display must have more than 1 color");
                }
                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            var displayInfo = new StringBuilder();

            if (this.size != null)
            {
                displayInfo.AppendFormat("Size: {0:F2} inches", this.size);
            }

            if (this.numberOfColors != null)
            {
                displayInfo.AppendFormat(", Colors: {0}", this.numberOfColors);
            }

            return displayInfo.Length > 0 ? displayInfo.ToString() : "There is no display info";
        }
    }
}
