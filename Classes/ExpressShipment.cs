using RouteOOP2.Structs;

namespace RouteOOP2.Classes 
{
    public class ExpressShipment : Shipment
    {
        // Extra fee
        private decimal extraFee;


        // ExtraFee property
        public decimal ExtraFee
        {
            get { return extraFee; }

            set
            {
                if (value >= 0)
                {
                    extraFee = value;
                }
            }
        }


        // Constructor
        public ExpressShipment(
            string trackingCode,
            string description,
            double weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            decimal extraFee)
            : base(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination)
        {
            if (extraFee >= 0)
            {
                ExtraFee = extraFee;
            }
        }


        // Override EstimatedCost
        public override decimal EstimatedCost
        {
            get
            {
                return base.EstimatedCost + ExtraFee;
            }
        }
    }
}