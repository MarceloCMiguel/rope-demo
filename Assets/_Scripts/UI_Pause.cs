using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Pause : MonoBehaviour
{
    GameManager gm;
    // Start is called before the first frame update
    public void Resume()
    {
        gm = GameManager.GetInstance();
        gm.setgamestate_game();
        Time.timeScale = 1;
        SceneManager.UnloadSceneAsync("Pause");
    }

    public void Menu()
    {
        gm = GameManager.GetInstance();
        gm.setgamestate_game();
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
}