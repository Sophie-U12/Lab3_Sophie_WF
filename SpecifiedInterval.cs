using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Sophie_WF
{
    public class SpecifiedInterval
    {
        private int numberA;

        public int NumberA
        {
            get { return numberA; }
            set { numberA = value; }
        }

        private int numberB;

        public int NumberB
        {
            get { return numberB; }
            set { numberB = value; }
        }

        public SpecifiedInterval()
        {
            NumberA = 0;
            NumberB = 0;
        }

        public SpecifiedInterval(int numberA, int numberB)
        {
            NumberA = numberA;
            NumberB = numberB;
        }

        public int GetCalculation()
        {
            if (numberB < numberA) throw new ArgumentOutOfRangeException($"Number A{numberA} > Number B{numberB}");
            int sum = 0;
            for(int i = numberA; i <= numberB; i++)
            {
                if(i % 19 == 0 && i % 3 == 2)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
