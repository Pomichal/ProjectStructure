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
        StartCoroutine(LoadScene("UIScene"));
    }

    IEnumerator LoadScene(string sceneName)
    {
        Debug.Log(sceneName);
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
    }
}
