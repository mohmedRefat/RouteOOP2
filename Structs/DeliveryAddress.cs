

namespace RouteOOP2.Structs
{
    public struct DeliveryAddress
    {
        public string Street;
        public string City;
        public int BuildingNumber;

        public DeliveryAddress(string street, string city, int buildingNumber)
        {
            Street = street;
            City = city;
            BuildingNumber = buildingNumber;
        }
        public string GetFullAddress()
        {
            return $"Building {BuildingNumber}, {Street}, {City}";
        }
    }
}