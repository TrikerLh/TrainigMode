namespace MourningRoutine;

public class MyMorningRoutine
{
    private IClock _internalClock;

    public MyMorningRoutine(IClock internalClock)
    {
        _internalClock = internalClock;
    }

    public string WhatShouldIDoNow()
    {
        var now = _internalClock.Now().TimeOfDay;
        if (now < new TimeSpan(0, 7, 0, 0)
            && now >= new TimeSpan(0, 6, 0, 0))
        {
            return "From 06:00 to 06:59 - Do exercise";
        }
        return "From 07:00 to 07:59 - Read and study";
    }
}

public interface IClock
{
    DateTime Now();
}