using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SummarizeTempsObjects
{
    public class TempCalculationEngine
    {
        List<int> _temperatures;
        public TempCalculationEngine(List<int> temperatures)
        {
            _temperatures = temperatures;
        }

        public int AverageTemperature()
        {
            int sumoftemps = 0;
            foreach(int temp in _temperatures)
            {
                sumoftemps += temp;
            }
            // add logic to calculate the average
            return sumoftemps/ _temperatures.Count; // <-- Replace this with the actual average
        }

        public int TempsAboveThreshold(int threshold)
        {
            int temperatureCount = 0;

            foreach (int temp in _temperatures)
            {
                if (temp > threshold)
                {
                    temperaureCount += 1;
                }
                
            }
            // add logic to calculate temps above the threshold
            return tempatureCount; // <-- Replace this with the number
        }

        public int TempsBelowThreshold(int threshold)
        {
            foreach (int temp in _temperatures)
            {

                if (temp < threshold)
                {
                    temperatureCount += 1;
                }
            }
            // add logic to calculate and return temps below the threshold
            return tempatureCount; // <-- Replace this with the number
        }

        public int TempsAtThreshold(int threshold)
        {
            int tempatureCount = 0;
            foreach (int temp in _tempatures)
            {
                if (temp == threshold)
                {
                    temptcount += 1;
                }

            }
               
            // add logic to calculate and return temps at the threshold
            return tempatureCount; // <-- Replace this with the number
        }

        public int NumberOfTemperatures()
        {
            // add logic to return the number of temparature readings
            return _temperatures.Count; // <-- Replace this with the number
        }
    }
}
