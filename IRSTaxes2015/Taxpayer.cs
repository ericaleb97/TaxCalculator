using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRSTaxes2015
{
    public class Taxpayer
    {
        //instantiating fields//
        public double salary { get; set; }
        public double tax { get; set; }
        public double remaining { get; set; }
        public string SSN { get; set; }
        public string Name { get; set; }

        private double _taxedSalary = -999;

        private filing _filing;
        public filing FilingType
        {
            get
            {
                return _filing;
            }
            set
            {
                _filing = value;
            }
        }

        public enum filing
        {
            Single,
            Head,
            Jointly,
            Seperately,
            Widower
        }

        public double taxedSalary {
            get
            {
                //turnary expression (fancy if/else statement)
                return _taxedSalary == -999 ? this.remainingSalary() : this._taxedSalary;
            }
            set
            {
                _taxedSalary = value;
            }
        }

        //Needed empty contructor for adaptor to work right
        public Taxpayer()
        {

        }

        //Constructor//
        public Taxpayer(double salary)
        {
            this.salary = salary;
        }

        //Method for calculating tax//
        public double CalculateTax()
        {
            if (0 <= salary && salary <= 9225)
                tax = salary * 0.10;
            else if (9226 <= salary && salary <= 37450)
                tax = 922.50 + ((salary - 9225) * 0.15);
            else if (37451 <= salary && salary <= 90750)
                tax = 5156.25 + ((salary - 37450) * 0.25);
            else if (90751 <= salary && salary <= 189300)
                tax = 18481.25 + ((salary - 90750) * 0.28);
            else if (189301 <= salary && salary <= 411500)
                tax = 46075.25 + ((salary - 189300) * 0.33);
            else if (411501 <= salary && salary <= 413200)
                tax = 119401.25 + ((salary - 411500) * 0.35);
            else
                tax = 119996.25 + ((salary - 413200) * 0.396);

            return tax;
        }

        public double CalculateHeadOfHouseHold()
        {
            if (0 <= salary && salary < 13150)
                tax = salary * 0.10;
            else if (13150 <= salary && salary < 50200)
                tax = 1315 + ((salary - 13150) * 0.15);
            else if (50200 <= salary && salary < 129600)
                tax = 6872.5 + ((salary - 50200) * 0.25);
            else if (129600 <= salary && salary < 209850)
                tax = 26722.5 + ((salary - 129600) * 0.28);
            else if (209850 <= salary && salary < 411500)
                tax = 49192.5 + ((salary - 209850) * 0.33);
            else if (411500 <= salary && salary < 439000)
                tax = 115737 + ((salary - 411500) * 0.35);
            else
                tax = 125362 + ((salary - 439000) * 0.396);
            return tax;
        }

        public double CalculateMarriedFilingJointly()
        {

            if (0 <= salary && salary < 18450)
                tax = salary * 0.10;
            else if (18450 <= salary && salary < 74900)
                tax = 1845 + ((salary - 18450) * 0.15);
            else if (74900 <= salary && salary < 151200)
                tax = 10312.5 + ((salary - 74900) * 0.25);
            else if (151200 <= salary && salary < 230450)
                tax = 29387.5 + ((salary - 151200) * 0.28);
            else if (230450 <= salary && salary < 411500)
                tax = 51577.5 + ((salary - 230450) * 0.33);
            else if (411500 <= salary && salary < 464850)
                tax = 111324 + ((salary - 411500) * 0.35);
            else
                tax = 129996.5 + ((salary - 464850) * 0.396);
            return tax;
        }

        //Method for calculating how much is left after taxes//
        public double remainingSalary()
        {
            remaining = salary - tax;
            return remaining;
        }

           

        //OPTIONAL CODE//

        //Getters//
        //public double getSalary()
        //{
        //    return salary;
        //}

        //public double getRemaining()
        //{
        //    return remaining;
        //}

        //public double getTax()
        //{
        //    return tax;
        //}

        //Setters//
        //public void setSalary(double salary)
        //{
        //    this.salary = salary;
        //}

        //public void setRemaining(double remaining)
        //{
        //    this.remaining = remaining;
        //}

        //public void setTax(double tax)
        //{
        //    this.tax = tax;
        //}
    }
}
