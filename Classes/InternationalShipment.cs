using RouteOOP2.Structs;

namespace RouteOOP2.Classes
{
    public class InternationalShipment : Shipment
    {
        // Private fields
        private string destinationCountry;
        private decimal customsFee;


        // DestinationCountry
        public string DestinationCountry
        {
            get { return destinationCountry; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    destinationCountry = value;
                }
            }
        }


        // CustomsFee
        public decimal CustomsFee
        {
            get { return customsFee; }

            set
            {
                if (value >= 0)
                {
                    customsFee = value;
                }
            }
        }


        // Constructor
        public InternationalShipment(
            string trackingCode,
            string description,
            double weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            string destinationCountry,
            decimal customsFee)
            : base(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination)
        {
            if (!string.IsNullOrWhiteSpace(destinationCountry))
            {
                DestinationCountry = destinationCountry;
            }
            else
            {
                DestinationCountry = "Unknown";
            }


            if (customsFee >= 0)
            {
                CustomsFee = customsFee;
            }
        }


        // Override EstimatedCost
        public override decimal EstimatedCost
        {
            get
            {
                return base.EstimatedCost + CustomsFee;
            }
        }


        // Override ShipmentPrint
        public override void ShipmentPrint()
        {
            base.ShipmentPrint();

            Console.WriteLine(
                $"Destination Country: {DestinationCountry}"
            );

            Console.WriteLine(
                $"Customs Fee: {CustomsFee} EGP"
            );
        }
    }
}