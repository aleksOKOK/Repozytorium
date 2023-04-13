using wyjatki;

internal class Program
{
    private static void Main(string[] args)
    {
        ZwierzakDomowy kot = new ZwierzakDomowy("pies", "kot", new DateTime(2077, 4, 20));
        try
        {
            Console.WriteLine(kot.ToString());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        RownanieKwadratowe aok = new RownanieKwadratowe(1, -5, 6);
        try
        {
            double[] tab = aok.ObliczRozwiazanie();
            Console.WriteLine(tab[0] + " " + tab[1]);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}