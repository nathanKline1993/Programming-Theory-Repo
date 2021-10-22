using UnityEngine.SceneManagement;

class StartInputHandler : InputHandler
{
    public void OnStartButtonClick()
    {
        SceneManager.LoadScene(1);
    }
}
