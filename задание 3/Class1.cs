using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_3
{
    public static class SalesAmountsOfEachEmployee
    {
        public static int CountUnderperformingEmployees(List<int> sales, int plan)
        {
            int EmployeeAmount = 0;

            foreach (int sale in sales)
            {
                if (sale < plan)
                {
                    EmployeeAmount++;
                }
            }

            return EmployeeAmount;
        }
    }
}
