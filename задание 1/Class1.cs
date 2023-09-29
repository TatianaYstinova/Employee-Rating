using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_1
{
    public static class EmployeeRating
    {
        public static int MaxRating ()
        {
            List<int> ratings = new List<int> { 85, 92, 78, 90, 88 };

            int maxRating = ratings[0];

            foreach (int rating in ratings)
            {
                if (rating > maxRating)
                {
                    maxRating = rating;
                }
            }

            return maxRating;
        }
    }
}
