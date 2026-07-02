using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialForecastingExample
{
    internal class ForecastCalculator
    {
        public static double PredictFutureValue(double currentValue, double growthRate, int years)
        {
            if (years == 0)
                return currentValue;

            return PredictFutureValue(currentValue * (1 + growthRate), growthRate, years - 1);
        }
    }
}