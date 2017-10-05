using Knn.Data;

namespace Knn.Calculation
{
    public interface IDistanceCalculator
    {
        double DistanceBetween(Adult first, Adult second);

    }
}
