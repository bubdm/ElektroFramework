using System;
using System.Linq;

namespace Utilities
{
    public class StringHelpers
    {
        public static string DeleteExtraSpaces(string value)
        {
            value = value.Trim();
            string newValue = String.Empty;
            for (int i = 0; i < value.Length; i++)
            {
                if(value[i]==' ' && value[i+1]==' ')
                    continue;
                newValue += value[i];
            }

            return newValue;
        }
    }
}