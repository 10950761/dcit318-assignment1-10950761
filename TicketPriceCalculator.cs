using System;
using System.Collections;
using System.Linq;
public class TicketPriceCalculator
{
    public static void Main(String[] arg){
        Console.WriteLine("Enter you age: ");
        int age = Convert.ToInt32(Console.ReadLine());
String ticketPrice;
if (age >= 65 || age <= 12){
    ticketPrice = "GHC7.00";
}
else {
    ticketPrice = "GHC10.00";
}
Console.WriteLine("Ticket price: " + ticketPrice);
    }
}