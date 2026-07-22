namespace MourningRoutine;

public class MyMorningRoutine(IClock internalClock)
{
    public string WhatShouldIDoNow()
    {
        var now = internalClock.Now().TimeOfDay;
        if (Between(now, 6, 7))
        {
            return new Task(6, 0, 6, 59, "Do exercise").ToString();
        }

        if (Between(now, 7, 8))
        {
            return new Task(7, 0, 7, 59, "Read and study").ToString();
        }

        if (Between(now, 8, 9))
        {
            return new Task(8, 0, 8, 59, "Have breakfast").ToString();
        }

        return "No activity";
    }

    private static bool Between(TimeSpan now, int startHour, int endHour) =>
        now >= new TimeSpan(0, startHour, 0, 0)
        && now < new TimeSpan(0, endHour, 0, 0);
}