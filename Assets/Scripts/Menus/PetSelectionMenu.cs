using UnityEngine;
using UnityEngine.UI;

public class PetSelectionMenu : MonoBehaviour
{
    public Text greetingText;

    private const string playerNameInputTextName = "PlayerName";

    // Start is called before the first frame update
    void Start()
    {
        if (GameData.Instance.TryGetValue(playerNameInputTextName, out var playerNameObj))
        {
            greetingText.text = $"Hello {playerNameObj}";
        }
    }
}
