using UnityEngine;

public class Circle : Shape // INHERITANCE
{
    private int _count;
    
    public override string MyName
    {
        // ENCAPSULATION
        get
        {
            return "Circle";
        }
    }

    // POLYMORPHISM
    // ABSTRACTION
    public override string CreatePersonalMessage()
    {
        _count++;
        
        var messages = new[]
        {
            "I’m endlessly round. My therapist says I have boundary issues.",
            "I roll into parties—literally",
            "I tried being edgy once. It didn’t stick."
        };
        var randomMessage = messages[Random.Range(0, messages.Length)];
        
        return $"Visit number {_count} this session. {randomMessage}";
    }
}