using CsvHelper;
using SampleCRUD.Model;
using System.Text;

namespace SampleCRUD.Data
{
    public class ManufacturerService : IManufacturer
    {
        public List<Manufacturer> GetManufacturers()
        {
            var manufacturers = ProcessFile("manufacturers.csv");

            return manufacturers;
        }

        public string Post(string manufacturer)
        {
            using StreamWriter file = new("manufacturers.csv", append: true);
            file.WriteLine(manufacturer);
            return manufacturer;
        }

        

        private List<Manufacturer> ProcessFile(string path)
        {
            return   
                File.ReadAllLines(path)
                        .Skip(1)
                        .Where(line => line.Length > 1)
                        .Select(Manufacturer.ParseFromCsv)
                        .ToList();
        }

    }
}
