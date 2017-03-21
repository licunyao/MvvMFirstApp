using System;
using firstApp.Services;
namespace firstApp.Services
{
	public class Calculation : ICalculation
	{
		public double TipAmount(double subTotal, int generosity)
		{
			return subTotal * ((double)generosity) / 100.0;
		}
	}
}
