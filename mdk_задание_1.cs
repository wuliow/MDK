public class Phone

{
    public int Number { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }
    public Phone(int number, string model, int weight)

    {
        Number = number;
        Model = model;
        Weight = weight;
        
        static void Main()
        {
            Phone phone1 = new Phone(78934261, "Fly");
            Phone phone2 = new Phone(72345677, "Samsung");
            Phone phone3 = new Phone(79308321, "Honor");
        }
        
    }

    public Phone(int number, string model)

    {
        Number = number;
        Model = model;
       
    }

    public Phone()

    {
        return;   
    }


}

class Program

{
    static void Main()

    {
        Phone phone1 = new Phone(89157753245, "Fly", 52);
        Console.WriteLine(ReceiveCall("Valentin"));
        Console.WriteLine(GetNumber(89157753245));
        Console.WriteLine("number = {0} model = {1} weight = {2}", phone1.Number, phone1.Model, phone1.Weight);

        Phone phone2 = new Phone(893074557923, "Samsung", 63);
        Console.WriteLine(ReceiveCall("Morison"));
        Console.WriteLine(GetNumber(893074557923));
        Console.WriteLine("number = {0} model = {1} weight = {2}", phone2.Number, phone2.Model, phone2.Weight);

        Phone phone3 = new Phone(89056479854, "Honor", 185);
        Console.WriteLine(ReceiveCall("Bratishkin"));
        Console.WriteLine(GetNumber(89056479854));
        Console.WriteLine("number = {0} model = {1} weight = {2}", phone3.Number, phone3.Model, phone3.Weight);

        sendMessege(123, 456, 789, 012, 345);
    }

    public static string ReceiveCall(string name)

    {
        return name;
    }

    public static int GetNumber(int number)

    {
        return number;
    }

    string receiveCall(string name, int number)

    {
        string var = "Вызывает" + name + "с номера" + number;
        return var;
    }

    static void sendMessege(params int[] parameters)

    {
        foreach (int parameter in parameters)
        
        {
            Console.WriteLine(parameter);
        }
    }
}