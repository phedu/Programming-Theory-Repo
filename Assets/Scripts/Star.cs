using UnityEngine;


public class Star : Shape // INHERITANCE
{
    public override string MyName
    {
        // ENCAPSULATION
        get
        {
            return "Star";
        }
    }

    // POLYMORPHISM
    // ABSTRACTION
    public override string CreatePersonalMessage()
    {
        var messages = new[]
        {
            "I was born to sparkle and stir drama.",
            "I’m on flags, trophies, and toddlers' drawings. Celebrity status, darling.",
            "Every point is an opinion—and I’ve got five!"
        };

        return messages[Random.Range(0, messages.Length)];
    }
}
