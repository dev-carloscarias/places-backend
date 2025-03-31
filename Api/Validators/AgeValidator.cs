namespace Places.Api.Validators;

public static class AgeValidator
{
    public static bool IsAdult(DateTime date)
    {
        int difference = DateTime.Now.Year - date.Year;

        if (DateTime.Now.Month < date.Month || (date.Month == DateTime.Now.Month && DateTime.Now.Day < date.Day))
        {
            difference--;
        }

        return difference > 18;
    }
}