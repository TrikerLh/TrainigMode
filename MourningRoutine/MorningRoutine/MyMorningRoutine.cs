namespace MourningRoutine;

public class MyMorningRoutine(IClock internalClock)
{
    public string WhatShouldIDoNow()
    {
        var now = internalClock.Now().TimeOfDay;
        if (now < new TimeSpan(0, 7, 0, 0)
            && now >= new TimeSpan(0, 6, 0, 0))
        {
            return "From 06:00 to 06:59 - Do exercise";
        }
        return "From 07:00 to 07:59 - Read and study";
    }
}