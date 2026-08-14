using RouteOOP2.Classes;
using RouteOOP2.Structs;

class Program
{
    // public class Shipment
    // {
    //     public string TrackingCode { get; set; }
    // }

    // public class ExpressShipment : Shipment
    // {
    //     public decimal ExtraFee { get; set; }
    // }

    ///* Q2
    /*
    A | Shipment is parent class
    B | ExpressShipment : is child class
    C | Tracking code from parent (Shipment)
        Extra fee from child class

    D | Inheritance is more useful for reducing duplication
        and makes code more easier to maintain and read.
        It allows child class to extend parent class.
    */


    static void Main(string[] args)
    {
        /*
        q1

        / A

        * class is reference type when class obj is assigned
          to another value and you made change to that value
          both are changed because they refer to the same object.

        * struct is value type when you assigned it to another
          value it makes a separate copy from another value.

        / B

        * class support inheritance and complex relationships
          between objects.

        * struct is more useful for small and simple data.
        */


        // Create Delivery Center

        DeliveryCenter deliveryCenter = new DeliveryCenter();


        // Create Standard Shipment

        Console.WriteLine("==============================");
        Console.WriteLine("Standard Shipment");
        Console.WriteLine("==============================");

        Console.Write("Tracking Code: ");
        string standardTrackingCode = Console.ReadLine()!;

        Console.Write("Description: ");
        string standardDescription = Console.ReadLine()!;

        Console.Write("Weight: ");
        double standardWeight =
            double.Parse(Console.ReadLine()!);

        Console.Write("Delivery Fee: ");
        decimal standardDeliveryFee =
            decimal.Parse(Console.ReadLine()!);

        Console.Write("City: ");
        string standardCity = Console.ReadLine()!;

        Console.Write("Street: ");
        string standardStreet = Console.ReadLine()!;

        Console.Write("Building Number: ");
        int standardBuildingNumber =
            int.Parse(Console.ReadLine()!);


        // Create address

        DeliveryAddress standardAddress =
            new DeliveryAddress(
                standardStreet,
                standardCity,
                standardBuildingNumber
            );


        // Create standard shipment

        StandardShipment standardShipment =
            new StandardShipment(
                standardTrackingCode,
                standardDescription,
                standardWeight,
                standardDeliveryFee,
                standardAddress
            );


        // Add shipment to delivery center

        if (deliveryCenter.AddShipment(standardShipment))
        {
            Console.WriteLine(
                "Standard shipment added successfully."
            );
        }
        else
        {
            Console.WriteLine(
                "Delivery center is full."
            );
        }



        // Create Express Shipment

        Console.WriteLine("\n==============================");
        Console.WriteLine("Express Shipment");
        Console.WriteLine("==============================");

        Console.Write("Tracking Code: ");
        string expressTrackingCode = Console.ReadLine()!;

        Console.Write("Description: ");
        string expressDescription = Console.ReadLine()!;

        Console.Write("Weight: ");
        double expressWeight =
            double.Parse(Console.ReadLine()!);

        Console.Write("Delivery Fee: ");
        decimal expressDeliveryFee =
            decimal.Parse(Console.ReadLine()!);

        Console.Write("City: ");
        string expressCity = Console.ReadLine()!;

        Console.Write("Street: ");
        string expressStreet = Console.ReadLine()!;

        Console.Write("Building Number: ");
        int expressBuildingNumber =
            int.Parse(Console.ReadLine()!);

        Console.Write("Extra Fee: ");
        decimal extraFee =
            decimal.Parse(Console.ReadLine()!);


        // Create address

        DeliveryAddress expressAddress =
            new DeliveryAddress(
                expressStreet,
                expressCity,
                expressBuildingNumber
            );


        // Create express shipment

        ExpressShipment expressShipment =
            new ExpressShipment(
                expressTrackingCode,
                expressDescription,
                expressWeight,
                expressDeliveryFee,
                expressAddress,
                extraFee
            );


        // Add shipment to delivery center

        if (deliveryCenter.AddShipment(expressShipment))
        {
            Console.WriteLine(
                "Express shipment added successfully."
            );
        }
        else
        {
            Console.WriteLine(
                "Delivery center is full."
            );
        }



        // Create International Shipment

        Console.WriteLine("\n==============================");
        Console.WriteLine("International Shipment");
        Console.WriteLine("==============================");

        Console.Write("Tracking Code: ");
        string internationalTrackingCode =
            Console.ReadLine()!;

        Console.Write("Description: ");
        string internationalDescription =
            Console.ReadLine()!;

        Console.Write("Weight: ");
        double internationalWeight =
            double.Parse(Console.ReadLine()!);

        Console.Write("Delivery Fee: ");
        decimal internationalDeliveryFee =
            decimal.Parse(Console.ReadLine()!);

        Console.Write("City: ");
        string internationalCity =
            Console.ReadLine()!;

        Console.Write("Street: ");
        string internationalStreet =
            Console.ReadLine()!;

        Console.Write("Building Number: ");
        int internationalBuildingNumber =
            int.Parse(Console.ReadLine()!);

        Console.Write("Destination Country: ");
        string destinationCountry =
            Console.ReadLine()!;

        Console.Write("Customs Fee: ");
        decimal customsFee =
            decimal.Parse(Console.ReadLine()!);


        // Create address

        DeliveryAddress internationalAddress =
            new DeliveryAddress(
                internationalStreet,
                internationalCity,
                internationalBuildingNumber
            );


        // Create international shipment

        InternationalShipment internationalShipment =
            new InternationalShipment(
                internationalTrackingCode,
                internationalDescription,
                internationalWeight,
                internationalDeliveryFee,
                internationalAddress,
                destinationCountry,
                customsFee
            );


        // Add shipment to delivery center

        if (deliveryCenter.AddShipment(internationalShipment))
        {
            Console.WriteLine(
                "International shipment added successfully."
            );
        }
        else
        {
            Console.WriteLine(
                "Delivery center is full."
            );
        }



        // =========================================
        // Print All Shipments
        // =========================================

        Console.WriteLine("All Shipments");

        deliveryCenter.PrintAllShipments();



        // Search Shipment using String Indexer

        Console.WriteLine("\n==============================");
        Console.WriteLine("Search Shipment");
        Console.WriteLine("==============================");

        Console.Write("Enter Tracking Code: ");

        string searchTrackingCode =
            Console.ReadLine()!;


        Shipment? foundShipment =
            deliveryCenter[searchTrackingCode];


        if (foundShipment != null)
        {
            Console.WriteLine("\nShipment Found:");

            foundShipment.ShipmentPrint();
        }
        else
        {
            Console.WriteLine("Shipment not found.");
        }



        // Remove Shipment

        Console.WriteLine("\n==============================");
        Console.WriteLine("Remove Shipment");
        Console.WriteLine("==============================");

        Console.Write("Enter Tracking Code to remove: ");

        string removeTrackingCode =
            Console.ReadLine()!;


        if (deliveryCenter.RemoveShipment(removeTrackingCode))
        {
            Console.WriteLine(
                "Shipment removed successfully."
            );
        }
        else
        {
            Console.WriteLine(
                "Shipment not found."
            );
        }



        // Print Remaining Shipments

        Console.WriteLine("\n==============================");
        Console.WriteLine("Remaining Shipments");
        Console.WriteLine("==============================");

        deliveryCenter.PrintAllShipments();
    }
}