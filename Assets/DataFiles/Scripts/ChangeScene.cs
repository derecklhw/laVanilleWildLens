using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
   public void LoadARScene()
    {
        SceneManager.LoadScene("LaVanilleWildLens");
    }

    public void ExitApp()
    {
        Application.Quit();
        Debug.Log("You have quit the app");
    }
}
