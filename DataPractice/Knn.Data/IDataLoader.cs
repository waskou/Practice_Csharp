using System.Collections.Generic;

namespace Knn.Data
{
    public interface IDataLoader
    {
        IEnumerable<Adult> LoadAdults();
    }
}
