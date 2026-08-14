using System;
using RouteOOP2.Structs;
namespace RouteOOP2.Classes
{
    public class Shipment
    {
        private string TrackingCode;
        private string Description;
        private double Weight;
        private decimal DeliveryFee;

        // Destination property of type DeliveryAddress
        // public read and write
        public DeliveryAddress Destination { get; set; }


        //* read only from ouside the struct no need for validation
        public string trackingCode
        {
            get { return TrackingCode; }
        }


        // read and write from outside
        // also we make description not empty or null
        public string description
        {
            get { return Description; }
            set
            {
                //* checking description is not empty or null or whitespace
                if (!string.IsNullOrWhiteSpace(value))
                {
                    Description = value;
                }
            }
        }


        // read and write from outside
        // also we make weight greater than 0
        public double weight
        {
            get { return Weight; }
            set
            {
                if (value > 0)
                {
                    Weight = value;
                }
            }
        }


        // public getter and private setter
        // with validation for delivery fee
        public decimal deliveryFee
        {
            get { return DeliveryFee; }
            private set
            {
                if (value > 0)
                {
                    DeliveryFee = value;
                }
            }
        }


        // calculate property
        public virtual decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + ((decimal)Weight * 5);
            }
        }


        // *****************************************
        // Constructor 1
        // *****************************************

        public Shipment(string trackingCode)
        {
            TrackingCode = "Unknown";
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;

            Destination = new DeliveryAddress(
                "Unknown",
                "Unknown",
                0
            );

            // validate tracking code is not empty or null
            if (!string.IsNullOrWhiteSpace(trackingCode))
            {
                TrackingCode = trackingCode;
            }
        }


        // *****************************************
        // Constructor 2
        // *****************************************

        public Shipment(
            string trackingCode,
            string description,
            double weight,
            decimal deliveryFee,
            DeliveryAddress destination)
        {
            TrackingCode = "Unknown";
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;

            Destination = destination;


            if (!string.IsNullOrWhiteSpace(trackingCode))
            {
                TrackingCode = trackingCode;
            }

            if (!string.IsNullOrWhiteSpace(description))
            {
                Description = description;
            }


            if (weight > 0)
            {
                Weight = weight;
            }


            if (deliveryFee > 0)
            {
                DeliveryFee = deliveryFee;
            }
        }


        // Update delivery fee method with validation

        public void UpdateDeliveryFee(decimal newDeliveryFee)
        {
            if (newDeliveryFee > 0)
            {
                DeliveryFee = newDeliveryFee;
            }
        }


        // Print shipment

        public  virtual void ShipmentPrint()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
    }
}