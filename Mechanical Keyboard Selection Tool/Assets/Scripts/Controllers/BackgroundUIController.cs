using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundUIController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventManager.current.onBackgroundUpdate += ChangeBackground;
    }

    // Update is called once per frame
    void ChangeBackground(int i)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        
        if (i == 0)
        {
            SceneManager.LoadScene("WhiteScene", LoadSceneMode.Additive);
            if(currentScene.name != "MainScene")
            {
                SceneManager.UnloadSceneAsync(currentScene);
            }
            Scene gameScene = SceneManager.GetSceneByName("WhiteScene");
            StartCoroutine(SetActive(gameScene));

        } else if (i == 1)
        {
            SceneManager.LoadScene("DeskScene", LoadSceneMode.Additive);
            Scene gameScene = SceneManager.GetSceneByName("DeskScene");
            if (currentScene.name != "MainScene")
            {
                SceneManager.UnloadSceneAsync(currentScene);
            }
            StartCoroutine(SetActive(gameScene));

        }
    }

       

     public IEnumerator SetActive(Scene scene)
    {
        int i = 0;
        while (i == 0)
        {
            i++;
            yield return null;
        }
        SceneManager.SetActiveScene(scene);
        yield break;
    }
}
