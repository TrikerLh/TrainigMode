using AwesomeAssertions;
using NSubstitute;

namespace MourningRoutine.Tests;

public class MorningRoutineShould
{
    private IClock _mockClock;

    [SetUp]
    public void Setup()
    {
        _mockClock = Substitute.For<IClock>();
    }

    [Test]
    public void ReturnDoExerciseBetween6To7()
    {
        var mourningRoutine = new MyMorningRoutine(_mockClock);
        _mockClock.Now().Returns(new DateTime(2026, 07, 22, 6, 1, 0));

        var response = mourningRoutine.WhatShouldIDoNow();

        response.Should().Be("From 06:00 to 06:59 - Do exercise");
    }

    [Test]
    public void ReturnStudyBetween7To8()
    {
        var mourningRoutine = new MyMorningRoutine(_mockClock);
        _mockClock.Now().Returns(new DateTime(2026, 07, 22, 7, 1, 0));
        
        var response = mourningRoutine.WhatShouldIDoNow();
        
        response.Should().Be("From 07:00 to 07:59 - Read and study");
    }
}