using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator
{
    public class InvoiceSummary : object
    {
        public int numberofRides;
        public double totalFair;
        public double average;
        public InvoiceSummary(int numberofRides, double totalFair)
        {
            this.numberofRides = numberofRides;
            this.totalFair = totalFair;
            this.average = (totalFair / numberofRides);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is InvoiceSummary))
            {
                return false;
            }
            InvoiceSummary imputedObject = (InvoiceSummary)obj;
            return this.numberofRides == imputedObject.numberofRides && this.totalFair == imputedObject.totalFair && this.average == imputedObject.average;
        }
    }
}