using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public abstract class InputHandler : MonoBehaviour
{
    protected int backSceneIndex = -1;

    public void OnBackClick()
    {
        SceneManager.LoadScene(backSceneIndex);
    }

    public void OnTextEdit(InputField textField)
    {
        GameData.Instance.SetValue(textField.name, textField.text);
    }
}
