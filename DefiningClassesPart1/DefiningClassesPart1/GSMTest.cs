namespace GSM
{
    using System;

   public class GSMTest
    {
       private GSM[] GSMCollection = {
            new GSM("Iphone 70", "Apple", 500, "Pesho", new Battery(BatteryType.NiCd, 72, 48), new Display(5.5, 2300000)),
            new GSM("Iphone 60", "Apple", 400, "Ivan", new Battery(BatteryType.Li_Ion, 70, 45), new Display(5.8, 32000000)),
            new GSM("Iphone 3","Apple")
        };
       public void DisplayInformation()
        {
            foreach (var gsm in GSMCollection)
            {
                gsm.Info();
            }
            GSM.IPhone4S.Info();
        }
    }
}
