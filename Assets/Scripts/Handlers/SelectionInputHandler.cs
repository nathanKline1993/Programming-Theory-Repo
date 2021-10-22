using UnityEngine.SceneManagement;
using UnityEngine.UI;

class SelectionInputHandler : InputHandler
{
    public SelectionInputHandler()
    {
        backSceneIndex = 0;
    }

    private void TransitionScene(string animal)
    {
        GameData.Instance.SetValue(DataNameConstants.AnimalDataName, animal);
        SceneManager.LoadScene(2);
    }

    public void OnCatClick()
    {
        TransitionScene(DataNameConstants.Cat);
    }

    public void OnDogClick()
    {
        TransitionScene(DataNameConstants.Dog);
    }

    public void OnPetNameEntered(InputField petNameInputField)
    {
        GameData.Instance.SetValue(DataNameConstants.PetNameDataName, petNameInputField.text);
    }
}
