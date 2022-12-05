namespace GaryGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            fxs.MainColor = "red";
            fxs.MaximumOccupancy = 4;

            Tesla modelS = new Tesla();
            modelS.MainColor = "silver";
            modelS.MaximumOccupancy = 5;

            Cessna mx410 = new Cessna();
            mx410.MainColor = "neon pink";
            mx410.MaximumOccupancy = 8;

            Ram classic1500 = new Ram();
            classic1500.MainColor = "blue";
            classic1500.MaximumOccupancy = 5;

            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();

            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop();

            mx410.Drive();
            mx410.Turn("left");
            mx410.Stop();

            classic1500.Drive();
            classic1500.Turn("right");
            classic1500.Stop();
        }
    }
}