namespace Enum;

enum Seasons
{
    Summer,//yaz
    Spring,//ilkbahar
    Autumun,//sonbahar
    Winter//kış
}
class Program
{
    static void Main(string[] args)
    {
        /*
         //Enum
        1-> enum, bir grup sabiti (değiştirilemez/salt okunur değişkenler) temsil eden özel bir "sınıftır".
        2-> belirli bir türdeki sabit değerleri temsil etmek için kullanılır.
         */
        Seasons season = Seasons.Winter;

        Console.WriteLine("Season:" + season);

        if (season==Seasons.Winter)
        {
            Console.WriteLine("Kış ayındayız.");

        }
        else
        {
            Console.WriteLine("Kış ayında değiliz.");
        }

        Console.Read();
    }
}

