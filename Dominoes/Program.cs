class Dominoe
{
    int arriba;
    int abajo;

    public Dominoe(int arriba, int abajo) //constructor
    {
        this.arriba=arriba;
        this.abajo=abajo;
    }

    public static int operator +(Dominoe a,Dominoe b)
    {
        int total=a.arriba+a.abajo+b.arriba+b.abajo;
        return total;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Dominoe d1=new Dominoe(0,1);
        Dominoe d2=new Dominoe(2,3);
        int total=d1+d2;
        Console.WriteLine(total);

    }
}