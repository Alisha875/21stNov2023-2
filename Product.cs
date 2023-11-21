using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18_2
{
    public class Product
    {
        private int pid;
        private string pname;
        private double pprice;

        public Product(int pid, string pname, double pprice)
        {
            this.pid = pid;
            this.pname = pname;
            this.pprice = pprice;
        }

        public int Pid { get => pid; set => pid = value; }
        public string Pname { get => pname; set => pname = value; }
        public double Pprice { get => pprice; set => pprice = value; }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"Product ID: {Pid}\nProduct Name: {Pname}\nProduct Price: {Pprice}");
        }

        public virtual void SetInformation(int pid, string pname, double pprice, string herbsUsed, DateTime mfDate, DateTime expDate)
        {
            Pid = pid;
            Pname = pname;
            Pprice = pprice;
        }
    }
}
