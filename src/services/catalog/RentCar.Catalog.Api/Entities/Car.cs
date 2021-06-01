namespace RentCar.Catalog.Api.Entities
{
    public class Car
    {
        public string Name { get; private set; }
        public string Brand { get; private set; }
        public int Passengers  { get; private set; }
        public string Motor { get; private set; }
        public bool AirConditioning  { get; private set; }
        public bool Automatic { get; private set; }
    }
}