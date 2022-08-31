using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main starts here
            Console.Clear();

            var salary = new Money("10", "р.", "25", "коп.");
            salary.Print();
            var salary2 = new Money("12", "р.", "10", "коп.");
            salary2.Print();

            var c = Money.Sum(salary, salary2);
            c.Print();

            var d = Money.Difference(salary2, salary);
            d.Print();

            var e = new Money("10", "р.", "15", "коп.");
            e.PrintTransferCost(0.05);
        }
    }

    class Money
    {
        private int roubles;
        private string sRoub;
        private int kopejki;
        private string sKop;

        public Money(string nRoub, string sRoub, string nKop, string sKop)
        {
            if (sRoub == "коп.")
                _BreakMissing();
            else
                    if ((Convert.ToInt32(nRoub) < 0) || (Convert.ToInt32(nKop) < 0))
                        _BreakNegative();
            else
                Creating(nRoub, sRoub, nKop, sKop);
        }
        public Money(string value, string description)
        {
            if (description == "коп.")
            {
                Creating("0", "р.", value, description);
            }

            if (description == "р.")
            {
                Creating(value, description, "0", "коп.");
            }
            if ((this.roubles < 0) || (this.kopejki < 0))
            {
                _BreakNegative();
            }

        }
        public Money(string str)
        {
            var values = str.Split(' ').ToArray();
            if (values.Length == 2)
                {
                    if (values[1] == "коп.")
                    {
                        Creating("0", "р.", values[0], values[1]);
                    }

                    if (values[1] == "р.")
                    {
                        Creating(values[0], values[1], "0", "коп.");
                    }
                    if ((this.roubles < 0) || (this.kopejki < 0))
                    {
                        _BreakNegative();
                    }
                }
            if (values.Length == 4)
            {
                if (values[1] == "коп.")
                _BreakMissing();
                else
                        if ((Convert.ToInt32(values[0]) < 0) || (Convert.ToInt32(values[2]) < 0))
                    _BreakNegative();
                else
                    Creating(values[0], values[1], values[2], values[3]);
            }
        }
        // -------------------------------------------------------------------------
        private void Creating(string rbs, string rDesk, string kps, string kpsDesk)
        {
            this.roubles = 0;
            this.kopejki = 0;
            this.sRoub = rDesk;
            this.sKop = kpsDesk;

            this.roubles = Convert.ToInt32(rbs);
            this.kopejki = Convert.ToInt32(kps);
            if (this.kopejki > 99)
            {
                this.roubles += this.kopejki / 100;
                this.kopejki %= 100;
            }
        }
        //--------------------------------------------------------------------------
        private void _BreakNegative() => throw new ArgumentException ("Не может быть отрицательным!");
        private void _BreakMissing() => Console.WriteLine("Рубли и копейки перепутаны местами!");

        public void Print()
        {
            if (this.roubles > 0)
                Console.WriteLine("{0} {1} {2} {3}", this.roubles, this.sRoub, this.kopejki, this.sKop);
            else
                Console.WriteLine("{0} {1}", this.kopejki, this.sKop);
        }

        public void PrintTransferCost(double tax)
        {
            double countTaxes = this.roubles * 100 + this.kopejki;
            countTaxes *= (1 + tax);
            var roublesTax = (int)(countTaxes / 100);
            var kopejkiTax = (int)(Math.Ceiling(countTaxes) % 100);
            if (roublesTax != 0)
                Console.WriteLine("{0} {1} {2} {3}", roublesTax, this.sRoub, kopejkiTax, this.sKop);
            else
                Console.WriteLine("{0} {1}", kopejkiTax, this.sKop);
            //
            //Console.WriteLine(string.Join(" ", roublesTax, this.sRoub, kopejkiTax, this.sKop));
            //
        }

        public static Money Sum(Money a, Money b)
        {
            var rb = a.roubles + b.roubles;
            var kp = a.kopejki + b.kopejki;
            var c = new Money(rb.ToString(), "р.", kp.ToString(), "коп.");
            return c;
        }

        public static Money Difference(Money a, Money b)
        {

            var rb = a.roubles - b.roubles;
            var kp = a.kopejki - b.kopejki;
            if(kp <0 )
            {
                rb--;
                kp += 100;
            }
            var c = new Money(rb.ToString(), "р.", kp.ToString(), "коп.");
            return c;
        }
    }
}