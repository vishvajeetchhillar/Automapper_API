namespace AM.API.HelperFunctions
{
    public static class HelperFunction
    {
        public static int GetCurrentAge(this DateTimeOffset dateTimeOffset)
        {
            var currentDate = DateTime.UtcNow;
            int age=currentDate.Year-dateTimeOffset.Year;
            if(currentDate<dateTimeOffset.AddYears(age))
            {
                age--;
            }
            return age;
        }
    }
}
