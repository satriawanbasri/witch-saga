using WitchSaga.Models;
using WitchSaga.Services;
using WitchSaga.Services.Interface;

namespace WitchSaga
{
    public class Program
    {
        private static readonly IWitchKillingPattern _witchKillingPattern = new WitchKillingPattern();

        public static void Main()
        {
            //Example usage
            var people = new List<Person>
            {
                new Person(10, 12),
                new Person(13, 17)
            };

            double averageKilled = _witchKillingPattern.CalculateAverageKilled(people);
            Console.WriteLine($"Average Number of Villagers Killed: {averageKilled}");
        }
    }
}
