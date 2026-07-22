namespace MourningRoutine;

public class Task(int beginHour, int beginMinute, int endHour, int endMinute, string description) : ITask
{
    public override string ToString()
    {
        return $"From {beginHour:00}:{beginMinute:00} to {endHour:00}:{endMinute:00} - {description}";
    }
}