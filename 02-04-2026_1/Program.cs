namespace _02_04_2026_1;

public delegate void Notify(string message);
internal class Program
{
    static void Main(string[] args)
    {
       Notify notify = new Notify(SendEmail);
        notify += SendSMS;
        notify += SendWhatsApp;
        notify("Order Placed");
        Console.WriteLine("---- After Removing SMS ----");
        notify -= SendSMS;
        notify("Order Shipped");
    }

    static void SendEmail(string message)
    {
        Console.WriteLine("Email Sent: "+message);
    }

    static void SendSMS(string message)
    {
        Console.WriteLine("SMS Sent: " + message);
    }

    static void SendWhatsApp(string message)
    {
        Console.WriteLine("WhatsApp Sent: " + message);
    }
}
