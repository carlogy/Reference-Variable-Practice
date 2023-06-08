namespace HeadStartCh4Exercice;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Press 1 for Lloyd, 2 for Lucinda, 3 to swap: ");
        var input = Console.ReadLine();
        var IntInput = Convert.ToInt32(input);

        var lucinda = new Elephant() { name = "Lucinda", EarSize = 33 };
        var lloyd = new Elephant() { name = "Lloyd", EarSize = 40 };

        if (IntInput == 1)
        {
            Console.WriteLine("Calling lloyd.WhoAmI()");
            lloyd.WhoAmI();
            

        }
        else if(IntInput == 2)
        {
            Console.WriteLine("Calling lucinda.WhoAmI()");
            lucinda.WhoAmI();
            
        }else if (IntInput == 3)
        {
            Console.WriteLine("Reference variables have been swapped.");

            Elephant Holder;
            Holder = lloyd;
            lucinda = Holder;
            lucinda.WhoAmI();
            lloyd.WhoAmI();
        }

        Console.ReadLine();
    }
    
    
}

public class Elephant
{

    public string name;
    public int EarSize;

    public void WhoAmI()
    {
        Console.WriteLine($"My name is {name}");
        Console.WriteLine($"My ears are {EarSize} inches tall.");

        
    }

    





}

