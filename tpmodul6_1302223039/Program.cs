using tpmodul6_1302223039;
internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Muhammad Zidan Siva Fajar");
        video.increasePlayCount(20);
        video.printVideoDetails();
    }
}