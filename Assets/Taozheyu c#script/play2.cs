using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Play2 : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadMyScene(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);

    }

    public void LoadMyScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}