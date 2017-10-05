using Knn.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knn.ClientConsole
{
    class Program
    {
        static IDataLoader loader;

        static void Main(string[] args)
        {
            loader = new FileDataLoader("Data\\adult.data.txt");
            loader.LoadAdults().ToList().ForEach(a => Console.WriteLine(a.Workclass));
        }
    }
}
