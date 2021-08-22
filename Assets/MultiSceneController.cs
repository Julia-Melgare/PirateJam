using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MultiSceneController : MonoBehaviour
{
    public string uiScene;
    public string gameplayScene;

    public void LoadFirstLevel()
    {
        SceneManager.LoadSceneAsync(gameplayScene);
        SceneManager.LoadSceneAsync(uiScene, LoadSceneMode.Additive);
        SceneManager.LoadSceneAsync("Level01", LoadSceneMode.Additive);
    }

    public void LoadMenu()
    {
        SceneManager.LoadSceneAsync("TitleScene");
    }


}
