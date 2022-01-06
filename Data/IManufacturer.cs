using SampleCRUD.Model;

namespace SampleCRUD.Data
{
    public interface IManufacturer
    {
        List<Manufacturer> GetManufacturers();
        public string Post(string manufacturer);
    }
}
