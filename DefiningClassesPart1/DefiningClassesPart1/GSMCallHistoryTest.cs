namespace GSM
{
    using System;

    class GSMCallHistoryTest
    {
        private GSM Gsm = new GSM("M2", "Sony");
        private const decimal PricePerMinute = 0.37m;

        public void Functionality()
        {
            Gsm.AddCall(new Call(new DateTime(2016, 06, 09, 12, 00, 05), "0888 88 88 88", 100));
            Gsm.AddCall(new Call(new DateTime(2016, 06, 06, 13, 04, 10), "0777 77 77 77", 200));

            Console.WriteLine(Gsm.CallHistory);

            Console.WriteLine("Total price: {0} BGN", Gsm.GetPrice(PricePerMinute));

            Gsm.RemoveLongestCall();

            Console.WriteLine(
             "Total price after removing longest call is {0} BGN", Gsm.GetPrice(PricePerMinute));

            Gsm.ClearHistory();

            Console.WriteLine(Gsm.CallHistory);
        }
    }
}
