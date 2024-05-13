using System;
class Abonent
{
    public string Number;
    public string Name;
    public string Tariff;
    public double Balance;
    public DateTime ActivationDate;
    public bool HasInternet;
    public bool HasDigitalTV;
    public TimeSpan GetTimeExistence()
    {
        return DateTime.Now - ActivationDate;
    }
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("_________________________________________");
        Console.WriteLine("\t\tАбонент");
        Console.WriteLine("_________________________________________");
        Console.ResetColor();
        Console.WriteLine("Введiть номер телефону: "); string sNumber = Console.ReadLine();
        Console.WriteLine("Введiть iм'я абонента: "); string sName = Console.ReadLine();
        Console.WriteLine("Введiть тарифний план: "); string sTariff = Console.ReadLine();
        Console.WriteLine("Введiть баланс рахунку: "); string sBalance = Console.ReadLine();
        Console.Write("Введiть дату активацiї номера (рррр-мм-дд): "); 
        string sActivationDate = Console.ReadLine();
        Console.Write("Чи пiдключено iнтернет ? (y - так, n - нi) : ");
        ConsoleKeyInfo keyHasInternet = Console.ReadKey(); Console.WriteLine();
        Console.Write("Чи пiдключено цифрове ТБ ? (y - так, n - нi) : ");
        ConsoleKeyInfo keyHasDigitalTV = Console.ReadKey(); Console.WriteLine();

        Abonent OurAbonent = new Abonent();
        OurAbonent.Number = sNumber;
        OurAbonent.Name = sName;
        OurAbonent.Tariff = sTariff;
        OurAbonent.Balance = double.Parse(sBalance);
        OurAbonent.ActivationDate = DateTime.Parse(sActivationDate);
        OurAbonent.HasInternet = keyHasInternet.Key == ConsoleKey.Y ? true : false;
        OurAbonent.HasDigitalTV = keyHasDigitalTV.Key == ConsoleKey.Y ? true : false;

        TimeSpan timeExistence = OurAbonent.GetTimeExistence();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine();
        Console.WriteLine("_______________________________________________");
        Console.WriteLine("\t\tДанi про абонента ");
        Console.WriteLine("_______________________________________________");
        Console.ResetColor();
        Console.WriteLine("Номер телефону: " + OurAbonent.Number);
        Console.WriteLine("Iм'я: " + OurAbonent.Name);        
        Console.WriteLine("Тарифний план: " + OurAbonent.Tariff);
        Console.WriteLine("Баланс: " + OurAbonent.Balance);
        Console.WriteLine("Дата активацiї: " + OurAbonent.ActivationDate);
        Console.WriteLine(OurAbonent.HasInternet ? "Пiдключено iнтернет" : "Iнтернет не пiдключено");
        Console.WriteLine(OurAbonent.HasDigitalTV ? "Пiдключено цифрове ТБ" : "Цифрове ТБ не пiдключено");
        Console.WriteLine($"Час iснування номера: {timeExistence.Days} днiв");
        Console.WriteLine();
    }
}