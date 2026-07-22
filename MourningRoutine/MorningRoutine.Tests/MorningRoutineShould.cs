using AwesomeAssertions;
using NSubstitute;

namespace MourningRoutine.Tests;

public class MorningRoutineShould
{
    private IClock _mockClock;
    private MyMorningRoutine _mourningRoutine;

    [SetUp]
    public void Setup()
    {
        _mockClock = Substitute.For<IClock>();
        _mourningRoutine = new MyMorningRoutine(_mockClock);
    }

    [Test]
    public void ReturnDoExerciseBetween6To7()
    {
        _mockClock.Now().Returns(new DateTime(2026, 07, 22, 6, 1, 0));

        var response = _mourningRoutine.WhatShouldIDoNow();

        response.Should().Be("From 06:00 to 06:59 - Do exercise");
    }

    [Test]
    public void ReturnStudyBetween7To8()
    {
        _mockClock.Now().Returns(new DateTime(2026, 07, 22, 7, 1, 0));
        
        var response = _mourningRoutine.WhatShouldIDoNow();
        
        response.Should().Be("From 07:00 to 07:59 - Read and study");
    }

    [Test]
    public void ReturnHaveBreakfastBetween8To9()
    {
        _mockClock.Now().Returns(new DateTime(2026, 07, 22, 8, 1, 0));
        
        var response = _mourningRoutine.WhatShouldIDoNow();
        
        response.Should().Be("From 08:00 to 08:59 - Have breakfast");
    }

    [Test]
    public void ReturnNoActivityByDefault()
    {
        _mockClock.Now().Returns(new DateTime(2026, 07, 22, 10, 1, 0));
        
        var response = _mourningRoutine.WhatShouldIDoNow();
        
        response.Should().Be("No activity");
    }
}