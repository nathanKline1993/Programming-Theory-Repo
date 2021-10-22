class ActionInputHandler : InputHandler
{
    public PetActionMenu menuController;

    public ActionInputHandler()
    {
        backSceneIndex = 1;
    }

    public void OnEatClick()
    {
        menuController.MakePetEat();
    }
    
    public void OnSleepClick()
    {
        menuController.MakePetSleep();
    }

    public void OnTalkClick()
    {
        menuController.MakePetTalk();
    }
    
    public void OnWalkClick()
    {
        menuController.MakePetWalk();
    }
}
