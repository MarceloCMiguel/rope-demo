using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Pause : MonoBehaviour
{
    // Start is called before the first frame update
    public void Resume()
    {
        Time.timeScale = 1;
        SceneManager.UnloadSceneAsync("Pause");
    }

    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
}