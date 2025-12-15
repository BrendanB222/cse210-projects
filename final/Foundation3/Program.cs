using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 N Apple St", "Citytropolis", "Alabama", "USA");
        Lecture lecture = new Lecture("How to Make Perfect Toast", "Dr. Jonathan speaks on how to make the perfect piece of toast.", "5/28/26", "5:00 PM", address, "Dr. Alvin Jonathan", 100);
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayFullDetails();
        Console.WriteLine();
        lecture.DisplayShortDescription();
        Console.WriteLine();

        address = new Address("987 W Rocky Rd", "Kingston", "North Dakota", "USA");
        Reception reception = new Reception("Family Thanksgiving Dinner", "Come and have Thanksgiving dinner with us!", "11/27/25", "4:30 PM", address, "ricardozfamily@email.com");
        reception.DisplayStandardDetails();
        Console.WriteLine();
        reception.DisplayFullDetails();
        Console.WriteLine();
        reception.DisplayShortDescription();
        Console.WriteLine();

        address = new Address("456 S Maple St", "Metrotown", "Manitoba", "Canada");
        OutsideGathering outsideGathering = new OutsideGathering("Outdoor Wedding", "Tiffany Johnson and Mark Palmer are getting married here.", "11/5/26", "6:00 PM", address, "Partly cloudy");
        outsideGathering.DisplayStandardDetails();
        Console.WriteLine();
        outsideGathering.DisplayFullDetails();
        Console.WriteLine();
        outsideGathering.DisplayShortDescription();
        Console.WriteLine();
    }
}