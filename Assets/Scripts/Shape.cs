using UnityEngine;
using UnityEngine.UI;

public abstract class Shape : MonoBehaviour
{
    // ENCAPSULATION
    public abstract string MyName { get; }

    public virtual string CreatePersonalMessage()
    {
        return "I'm no shape. I'm all shapes. Do I exist or do I not exist?";
    }

    private void Awake()
    {
        GetComponentInChildren<Text>().text = MyName;
    }
}
