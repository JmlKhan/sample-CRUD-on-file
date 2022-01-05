using SampleCRUD.Model;

namespace SampleCRUD.Data
{
    public class ManufacturerService : IManufacturer
    {
        public List<Manufacturer> GetManufacturers()
        {
            var manufacturers = ProcessFile("manufacturers.csv");

            return manufacturers;
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
