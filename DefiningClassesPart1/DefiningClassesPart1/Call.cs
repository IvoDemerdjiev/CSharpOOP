namespace GSM
{
    using System;
    using System.Text;

   public class Call
    {

        public Call(DateTime dateTime, string dilledNumbers, decimal duration)
        {
            this.Date = dateTime.ToShortDateString();
            this.Time = dateTime.ToLongTimeString();
            this.DialledNumbers = dilledNumbers;
            this.Duration = duration;

        }

        public string Date { get; set; }

        public string Time { get; set; }

        public string DialledNumbers { get; set; }

        public decimal Duration { get; set; }

        public override string ToString()
        {
            var Info = new StringBuilder();

            Info.AppendFormat("Date: {0} ", this.Date);

            Info.AppendFormat("Time: {0} ", this.Time);

            Info.AppendFormat("DialledNumbers: {0} ", this.DialledNumbers);

            Info.AppendFormat("Duration: {0} ", this.Duration);

            return Info.ToString();
        }
    }
}
