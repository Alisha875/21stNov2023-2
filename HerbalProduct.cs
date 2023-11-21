using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18_2
{
   public class HerbalProduct : Product
    {
        private string herbsUsed;
        private DateTime mfDate;
        private DateTime expDate;

        public HerbalProduct(int pid, string pname, double pprice, string herbsUsed, DateTime mfDate, DateTime expDate) : base(pid, pname, pprice)
        {
            this.herbsUsed = herbsUsed;
            this.mfDate = mfDate;
            this.expDate = expDate;
        }

        public string HerbsUsed { get => herbsUsed; set => herbsUsed = value; }
        public DateTime MfDate { get => mfDate; set => mfDate = value; }
        public DateTime ExpDate { get => expDate; set => expDate = value; }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Herbs Used: {HerbsUsed}\nManufacturing Date: {MfDate}\nExpiry Date: {ExpDate}");
        }

        public override void SetInformation(int pid, string pname, double pprice, string herbsUsed, DateTime mfDate, DateTime expDate)
        {
            base.SetInformation(pid, pname, pprice, herbsUsed, mfDate, expDate);
        }
    }
}
