using StatePattern;
using System;

namespace TestingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Action cheeringMethod = CheerOnAdoptionCats;

            var catProfile = new Profile(cheeringMethod);

            catProfile.PostNewPhotos(2);

            Console.WriteLine(catProfile.NumberOfPhotos);

            catProfile.VerifyVaccination();

            catProfile.SendToDoctor();

            catProfile.RemoveOldPhotos(1);
            Console.WriteLine(catProfile.NumberOfPhotos);

            catProfile.PostNewPhotos(3);
            Console.WriteLine(catProfile.NumberOfPhotos);

            catProfile.Adopt();
        }

        private static void CheerOnAdoptionDogs()
        {
            Console.WriteLine("Wagging my tail from happiness");
        }

        private static void CheerOnAdoptionCats()
        {
            Console.WriteLine("Rubbing face against your legs from happiness");
        }
    }
}
