using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    void Awake()
    {
        App.gameManager = this;
    }

    void Start()
    {
        StartCoroutine(LoadScene("UIScene", new ShowScreenCommand<MenuScreen>()));
    }

    public void StartGame()
    {
        StartCoroutine(LoadScene("InGameScene", new SetupGameCommand(), true));
    }

    public void ReturnToMenu()
    {
        StartCoroutine(UnloadScene("InGameScene"));
        App.screenManager.Show<MenuScreen>();
    }

    IEnumerator LoadScene(string sceneName, ICommand afterSceneLoadedCommand, bool activate=false)
    {
        AsyncOperation op = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        op.allowSceneActivation = false;
        while(!op.isDone)
        {
            if(op.progress >= 0.9f && !op.allowSceneActivation)
            {
                op.allowSceneActivation = true;
            }
            yield return null;
        }
        // scene loaded

        if(activate)
            SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneName));
        afterSceneLoadedCommand.Execute();
    }

    IEnumerator UnloadScene(string sceneName)
    {
        AsyncOperation op = SceneManager.UnloadSceneAsync(sceneName);
        while(!op.isDone)
        {
            yield return null;
        }
        // scene unloaded
    }
}
