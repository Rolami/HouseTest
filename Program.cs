namespace HouseTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            House Villa = new House();
            Villa.GetMoreInfo();

            TerracedHouse TeHus = new TerracedHouse();
            TeHus.GetMoreInfo();

            Highrise HighHouse = new Highrise();
            HighHouse.GetMoreInfo();

        }
    }
}