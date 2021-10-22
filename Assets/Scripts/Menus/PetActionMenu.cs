using UnityEngine;
using UnityEngine.UI;

public class PetActionMenu : MonoBehaviour
{
    private Animal pet;

    public Text actionResultText;

    // Start is called before the first frame update
    void Start()
    {
        if (GameData.Instance.TryGetValue(DataNameConstants.AnimalDataName, out var animalName))
        {
            if (GameData.Instance.TryGetValue(DataNameConstants.PetNameDataName, out var petName))
            {
                pet = AnimalFactory.GetAnimal(animalName.ToString(), petName.ToString());
            }
        }
    }

    private void UpdateActionResultText(string newLineMessage)
    {
        actionResultText.text = $"{pet.Name}: {newLineMessage}\n{actionResultText.text}";
    }

    public void MakePetEat()
    {
        UpdateActionResultText(pet.Eat());
    }

    public void MakePetSleep()
    {
        UpdateActionResultText(pet.Sleep());
    }

    public void MakePetTalk()
    {
        UpdateActionResultText(pet.Talk());
    }

    public void MakePetWalk()
    {
        UpdateActionResultText(pet.Walk());
    }
}
