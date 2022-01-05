namespace SampleCRUD.Model
{
    public class Manufacturer
    {
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public string Country { get; set; }
        public int  Year { get; set; }

        internal static Manufacturer ParseFromCsv(string line)
        {
            var columns = line.Split(",");

            return new Manufacturer
            {
                Id = Guid.NewGuid(),
                Brand = columns[0],
                Country = columns[1],
                Year = int.Parse(columns[2])
            };
        }
    }
}
