namespace MourningRoutine;

public class MyMorningRoutine(IClock internalClock)
{
    public string WhatShouldIDoNow()
    {
        var now = internalClock.Now().TimeOfDay;
        if (Between(now, 6, 7))
        {
            return "From 06:00 to 06:59 - Do exercise";
        }

        if (Between(now, 7, 8))
        {
            return "From 07:00 to 07:59 - Read and study";
        }

        if (Between(now, 8, 9))
        {
            return "From 08:00 to 08:59 - Have breakfast";
        }

        return "No activity";
    }

    private static bool Between(TimeSpan now, int startHour, int endHour) =>
        now >= new TimeSpan(0, startHour, 0, 0)
        && now < new TimeSpan(0, endHour, 0, 0);
}