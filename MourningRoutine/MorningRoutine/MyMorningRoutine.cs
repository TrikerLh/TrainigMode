namespace MourningRoutine;

public class MyMorningRoutine(IClock internalClock)
{
    public string WhatShouldIDoNow()
    {
        var now = internalClock.Now().TimeOfDay;
        if (Between6And7(now))
        {
            return "From 06:00 to 06:59 - Do exercise";
        }
        if (Between7And8(now))
        {
            return "From 07:00 to 07:59 - Read and study";
        }
        return "From 08:00 to 08:59 - Have breakfast";
    }

    private static bool Between7And8(TimeSpan now) =>
        now < new TimeSpan(0, 8, 0, 0)
        && now >= new TimeSpan(0, 7, 0, 0);

    private static bool Between6And7(TimeSpan now) =>
        now < new TimeSpan(0, 7, 0, 0)
        && now >= new TimeSpan(0, 6, 0, 0);
}