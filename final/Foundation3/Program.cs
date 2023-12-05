class zmProgram
{
    static void Main()
    {
        zmAddress zmEventAddress = new zmAddress { zmStreet = "Street", zmCity = "City", zmState = "State", zmZipCode = "Zipcode" };

        zmEvent zmGenericEvent = new zmEvent("GenericName", "Generic Description", DateTime.Now, new TimeSpan(18, 30, 0), zmEventAddress);
        zmLecture zmLectureEvent = new zmLecture("LectureName", "Lecture Description", DateTime.Now.AddDays(7), new TimeSpan(14, 0, 0), zmEventAddress, "Speaker Name", 100);
        zmReception zmReceptionEvent = new zmReception("ReceptionName", "Reception Description", DateTime.Now.AddDays(14), new TimeSpan(20, 0, 0), zmEventAddress, "RSVP Email");
        zmOutdoorGathering zmOutdoorEvent = new zmOutdoorGathering("OutdoorName", "Outdoor Description", DateTime.Now.AddDays(30), new TimeSpan(12, 0, 0), zmEventAddress, "Sunny with a chance of clouds");


        Console.WriteLine("Generic Event Marketing Messages:");
        Console.WriteLine(zmGenericEvent.GetStandardDetails());
        Console.WriteLine(zmGenericEvent.GetFullDetails());
        Console.WriteLine(zmGenericEvent.GetShortDescription());

        Console.Write("Press enter to continue: ");
        Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Lecture Event Marketing Messages:");
        Console.WriteLine(zmLectureEvent.GetStandardDetails());
        Console.WriteLine(zmLectureEvent.GetFullDetails());
        Console.WriteLine(zmLectureEvent.GetShortDescription());

        Console.Write("Press enter to continue: ");
        Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Reception Event Marketing Messages:");
        Console.WriteLine(zmReceptionEvent.GetStandardDetails());
        Console.WriteLine(zmReceptionEvent.GetFullDetails());
        Console.WriteLine(zmReceptionEvent.GetShortDescription());

        Console.Write("Press enter to continue: ");
        Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Event Marketing Messages:");
        Console.WriteLine(zmOutdoorEvent.GetStandardDetails());
        Console.WriteLine(zmOutdoorEvent.GetFullDetails());
        Console.WriteLine(zmOutdoorEvent.GetShortDescription());
    }
}