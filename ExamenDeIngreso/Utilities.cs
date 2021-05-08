using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDeIngreso
{
    static class Utilities
    {
        public static void CheckPositiveNumbers(Func<bool> checkCondition, Action successCallback, Action failedCallback)
        {
            try
            {
                if (checkCondition())
                {
                    failedCallback();
                }
                else
                {
                    successCallback();
                }
            }
            catch
            {
                failedCallback();
            }
        }
    }
}
