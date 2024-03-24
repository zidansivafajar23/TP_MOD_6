using tpmodul6_1302223039;
internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Muhammad Zidan Siva Fajar");
        video.increasePlayCount(20);
        video.printVideoDetails();

        SayaTubeVideo video2 = new SayaTubeVideo("Many studies used DIY questionnaires which the validity are being questioned, while such questionnaire has been existed in emotional psychology (Bargas-Avila & Hornb, 2011)");
        video2.increasePlayCount(100000009);
        video2.printVideoDetails();

        SayaTubeVideo video3 = new SayaTubeVideo("Belajar C#");
        for (int i = 0; i < 20; i++)
        {
            video3.increasePlayCount(1000000);
        }
        video3.printVideoDetails();
    }
}