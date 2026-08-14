using RouteOOP2.Classes;
using RouteOOP2.Structs;

namespace RouteOOP2.Classes
{
    public class StandardShipment : Shipment
    {
        // Constructor
        // Constructor chaining using base
        public StandardShipment(
            string trackingCode,
            string description,
            double weight,
            decimal deliveryFee,
            DeliveryAddress destination)
            : base(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination)
        {
        }
    }
}