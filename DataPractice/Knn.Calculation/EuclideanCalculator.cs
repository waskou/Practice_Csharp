using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Knn.Data;
using Knn.Data.Enums;

namespace Knn.Calculation
{
    public class EuclideanCalculator : IDistanceCalculator
    {
        static Dictionary<Workclass, int> workClassScores = new Dictionary<Workclass, int>()
        {
            { Workclass.Federal_gov, 1 },
            { Workclass.Local_gov, 1 },
            { Workclass.Never_worked, 1 },
            { Workclass.Private, 1 },
            { Workclass.Self_emp_inc, 1 },
        };


        public double DistanceBetween(Adult first, Adult second)
        {
            var score = workClassScores[first.Workclass];
            workClassScores[first.Workclass] = 5;


            return Math.Sqrt(
                 Math.Pow(first.Age - second.Age, 2)
               + Math.Pow(first.Education - second.Education, 2));
        }
    }
}
