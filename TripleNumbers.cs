using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Sophie_WF
{
    public class TripleNumbers
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

		private int numberC;

		public int NumberC
		{
			get { return numberC; }
			set { numberC = value; }
		}

		public TripleNumbers()
		{
			NumberA = 0;
			NumberB = 0;
			numberC = 0;
		}

		public TripleNumbers(int numberA, int numberB, int numberC)
		{
			NumberA = numberA;
			NumberB = numberB;
			NumberC = numberC;
		}

		private double GetProduct()
		{
			return numberA * numberB * numberC;
		}

		private double GetSquareOfSum()
		{
			return Math.Pow(numberA + numberB + numberC, 2);
		}

		public double GetCalculation()
		{
			return (numberA % 2 == 0 && numberB % 2 == 0 && numberC % 2 == 0) 
				? GetProduct() : GetSquareOfSum();
        }
	}
}
