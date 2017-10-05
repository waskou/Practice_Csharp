using Knn.Data;
using System.Collections.Generic;

namespace Knn.Calculation
{
    public interface IClassifier
    {
        /// <summary> Prepares the learning module </summary>
        void Learn(IEnumerable<Adult> traningData);

        /// <summary> This method returns a bool for each item of the test data
        /// true if more than 50k  false if less than 50k </summary>
        IEnumerable<bool> Classify(IEnumerable<Adult> testData);

    }
}
