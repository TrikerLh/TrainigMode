using AwesomeAssertions;

namespace MourningRoutine.Tests;

public class MorningRoutineShould
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ReturnDoExerciseBetween6To7()
    {
        var mourningRoutine = new MyMorningRoutine();

        var response = mourningRoutine.WhatShouldIDoNow();

        response.Should().Be("From 06:00 to 06:59 - Do exercise");
    }

    [Test]
    public void ReturnStudyBetween7To8()
    {
        var mourningRoutine = new MyMorningRoutine();
        
        var response = mourningRoutine.WhatShouldIDoNow();
        
        response.Should().Be("From 07:00 to 07:59 - Read and study");
    }
}