// COMP30019 - Graphics and Interaction
// (c) University of Melbourne, 2022

public class SceneTransition : GameManagerClient
{
    public void GotoGameScene(float delay = 0f)
    {
        StartCoroutine(GameManager.GotoScene(GameManager.StartSceneName, delay));
    }

    public void GotoMenuScene(float delay = 0f)
    {
        StartCoroutine(GameManager.GotoScene(GameManager.MenuSceneName, delay));
    }

    public void GotoEndScene(float delay = 0f)
    {
        StartCoroutine(GameManager.GotoScene(GameManager.EndSceneName, delay));
    }
}