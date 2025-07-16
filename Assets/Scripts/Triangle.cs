
using System;

public class Triangle : Shape // INHERITANCE
{
    public override string MyName
    {
        // ENCAPSULATION
        get
        {
            return "Triangle";
        }
    }

    // POLYMORPHISM
    // ABSTRACTION
    public override string CreatePersonalMessage()
    {
        var currentTime = DateTime.Now;

        if (currentTime.Hour < 12)
        {
            return "Good morning. I'm sharp, pointy, and always caught in a love triangle.";
        }
        else if (currentTime.Hour >= 12 && currentTime.Hour < 17)
        {
            return "Good afternoon. Three’s company? More like three sides of chaos.";
        }
        else
        {
            return "Good evening. I’m the shape of pizza, and that gives me power.";
        }
    }
}
