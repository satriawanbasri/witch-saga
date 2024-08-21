using WitchSaga.Models;

namespace WitchSaga.Services.Interface
{
    public interface IWitchKillingPattern
    {
        int NumberOfVillagersKilled(int year);
        double CalculateAverageKilled(List<Person> people);
    }
}
