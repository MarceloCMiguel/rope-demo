using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Pause : MonoBehaviour
{
    // Start is called before the first frame update
    public void Resume()
    {
        SceneManager.UnloadSceneAsync("Pause");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}