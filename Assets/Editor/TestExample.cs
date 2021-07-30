using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class TestExample
{
    [Test]
    public void TestEx()
    {
        var x = 2;
        var y = 10;

        var equation = x * y;

        var expected = 20;

        //testing for true
        Assert.That(equation, Is.EqualTo(expected));

        //testing for false
        //Assert.That(equation, Is.EqualTo(y));
    }
}
