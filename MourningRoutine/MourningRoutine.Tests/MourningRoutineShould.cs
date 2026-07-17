using AwesomeAssertions;

namespace MourningRoutine.Tests;

public class MourningRoutineShould
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ReturnDoExerciseBetween6To7()
    {
        var mourningRoutine = new MyMourningRoutine();

        var response = mourningRoutine.WhatShouldIDoNow();

        response.Should().Be("From 06:00 to 06:59 - Do exercise");
    }
}