Country country1 = new Country();
{
    System.Console.WriteLine();
    System.Console.Write("Name of Country: ");
    country1.name = Console.ReadLine();
    System.Console.Write("Capital of Country: ");
    country1.capital = Console.ReadLine();
    System.Console.Write("Population in Country: ");
    country1.population = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Language of Country: ");
    country1.officalLanguae = Console.ReadLine();
    string? cap;
    cap = country1.capital;
    string? Language;
    Language = country1.officalLanguae;
    int popular;
    popular = country1.population;
    System.Console.WriteLine(country1.GetInfoCountry());
    System.Console.WriteLine(country1.GetName());
    System.Console.WriteLine(country1.GetCapital(cap));
    System.Console.WriteLine(country1.GetPopulation(popular));
    System.Console.WriteLine(country1.GetOfficalLanguage(Language));
}
class Country
{
    public string? name;
    public string? capital;
    public int population;
    public string? officalLanguae;


    public string GetInfoCountry()
    {
        System.Console.WriteLine();
        return $"Name of Country: {name} , Capital: {capital} , Population: {population} , Language: {officalLanguae}";
    }


    public string GetName()
    {
        System.Console.WriteLine();
        return $"Name of Country: {name}";
    }
    public string GetCapital(string capital)
    {
        return $"Capital: {capital}";
    }
    public int GetPopulation(int population)
    {
        System.Console.Write("Population: ");
        return population;
    }
    public string GetOfficalLanguage(string officalLanguae)
    {
        return $"Language: {officalLanguae}";
    }
}
