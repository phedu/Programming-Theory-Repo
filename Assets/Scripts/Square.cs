
using System;

public class Square : Shape // INHERITANCE
{
    private DateTime _lastTimeVisited = DateTime.MinValue;
    
    public override string MyName
    {
        // ENCAPSULATION
        get
        {
            return "Square";
        }
    }

    // POLYMORPHISM
    // ABSTRACTION
    public override string CreatePersonalMessage()
    {
        var lastTime = _lastTimeVisited;
        _lastTimeVisited = DateTime.Now;
        
        if (lastTime == DateTime.MinValue)
        {
            return "Hooray - first time selected. I’m basically four right angles in a trench coat.";
        }
        else if (DateTime.Now.Subtract(lastTime!).TotalMinutes < 2)
        {
            return "Hi again, I don’t bend—I’m emotionally and geometrically rigid.";
        }
        else
        {
            return "Long time no see, perfect symmetry, zero spontaneity.";
        }
    }
}
