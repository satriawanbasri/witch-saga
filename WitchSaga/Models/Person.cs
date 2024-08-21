namespace WitchSaga.Models
{
    public class Person
    {
        public int AgeOfDeath { get; set; }
        public int YearOfDeath { get; set; }

        public Person(int ageOfDeath, int yearOfDeath)
        {
            AgeOfDeath = ageOfDeath;
            YearOfDeath = yearOfDeath;
        }

        public int CalculateYearOfBirth()
        {
            if (AgeOfDeath <= 0 || YearOfDeath <= 0 || YearOfDeath < AgeOfDeath)
            {
                return -1;
            }
            return YearOfDeath - AgeOfDeath;
        }
    }
}
