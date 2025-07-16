using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TMP_Text gameResultText;
    public TMP_Text messageText;
    public Shape[] shapes = new Shape[4];
    public ToggleGroup toggleGroup;

    public void SubmitGuess()
    {
        var userOption = toggleGroup.ActiveToggles().FirstOrDefault();
        if (userOption != null)
        {
            var userShape = userOption.GetComponent<Shape>();
            
            var randomShape = shapes[Random.Range(0, shapes.Length)];

            var gameResult = $"Randomly selected {randomShape.MyName}.";
            if (randomShape == userShape)
            {
                gameResult = $"{gameResult} You Win!"; 
            }
            else
            {
                gameResult = $"{gameResult} You Lose!";
            }
            gameResultText.text = gameResult;
            
            messageText.text = randomShape.CreatePersonalMessage();
        }
    }
}
