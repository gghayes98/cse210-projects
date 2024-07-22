using Foundation3;
using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("48 W 2 S", "Rexburg", "ID", "United States");
        Address address2 = new Address("494 Adams Dr", "Ithaca", "NY", "United States");
        Address address3 = new Address("31 Border St", "Edmunstion", "NB", "Canada");

        LectureEvent lecture = new LectureEvent("Innovations in Artificial Intelligence: Past, Present, and Future", 
            "Join Dr. Emily Thompson for an engaging lecture on the advancements in artificial intelligence, exploring its historical roots, current breakthroughs, and future potential. This talk will delve into AI's transformative impact on various industries and its ethical considerations.",
            "September 15, 2024", "3:00 pm", address1, "Dr. Emily Thompson", 400);

        ReceptionEvent reception = new ReceptionEvent("Alumni Networking Reception",
            "Reconnect with fellow alumni at our annual networking reception. This event provides a great opportunity to catch up with old friends, make new connections, and learn about the latest developments at the university. Hors d'oeuvres and refreshments will be served.",
            "October 10, 2024", "6:00 pm", address2, "alumni.reception@university.edu");

        OutdoorEvent outdoor = new OutdoorEvent("Autumn Festival",
            "Celebrate the beauty of autumn at our outdoor festival in Central Park. Enjoy live music, food stalls, craft booths, and fun activities for all ages. Don't forget to bring a blanket and a picnic to fully enjoy the day.",
            "October 5, 2024", "11:00 am", address3, "Partly cloudy with a chance of light showers, high of 68°F (20°C), light breeze from the northwest.");

        Console.WriteLine("--Lecture Event--");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDetails());

        Console.WriteLine("\n--Reception Event--");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDetails());

        Console.WriteLine("\n--Outdoor Event--");
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine(outdoor.GetShortDetails());
    }
}