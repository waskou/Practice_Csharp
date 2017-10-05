using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Knn.Data
{
    public class FileDataLoader : IDataLoader
    {
        private string fileName;

        public FileDataLoader(string fileName)
        {
            this.fileName = fileName;
        }

        public IEnumerable<Adult> LoadAdults()
        {
            var allAdults = File.ReadAllLines(fileName);
            return allAdults 
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Select((line) => new Adult(line));
        }
    }
}
