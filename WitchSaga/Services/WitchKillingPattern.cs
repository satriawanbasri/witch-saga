using WitchSaga.Models;
using WitchSaga.Services.Interface;

namespace WitchSaga.Services
{
    public class WitchKillingPattern : IWitchKillingPattern
    {
        public int NumberOfVillagersKilled(int year)
        {
            if (year <= 0)
            {
                return -1;
            }
            if (year == 1) return 1;
            if (year == 2) return 2;

            int[] kills = new int[year];
            kills[0] = 1;
            kills[1] = 1;
            for (int i = 2; i < year; i++)
            {
                kills[i] = kills[i - 1] + kills[i - 2];
            }

            int totalKills = 0;
            for (int i = 0; i < kills.Count(); i++)
            {
                totalKills += kills[i];
            }

            return totalKills;
        }

        public double CalculateAverageKilled(List<Person> people)
        {
            if (people == null || people.Count == 0)
            {
                return -1;
            }

            double totalKilled = 0;
            int validCount = 0;

            foreach (var person in people)
            {
                int birthYear = person.CalculateYearOfBirth();
                if (birthYear == -1)
                {
                    return -1;
                }
                int killedInYear = NumberOfVillagersKilled(birthYear);
                if (killedInYear == -1)
                {
                    return -1;
                }
                totalKilled += killedInYear;
                validCount++;
            }

            return validCount > 0 ? totalKilled / validCount : -1;
        }

    }
}
