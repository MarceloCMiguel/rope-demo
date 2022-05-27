using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager
{

    private static GameManager _instance;
    public enum GameState { MENU, GAME, PAUSE, ENDGAME };

   public GameState gameState { get; private set; }
   public double distance;
   public bool passou;
   public int fase;
   public static GameManager GetInstance()
   {
       
       if(_instance == null)
       {
           _instance = new GameManager();
       }

       return _instance;
   }
   private GameManager()
   {
       SceneManager.LoadScene(0);
       passou = false;
       distance = 10;
       gameState = GameState.GAME;
   }

   public void NextScene(){
       distance = 10;
        SceneManager.LoadScene(1);
        passou = false;
//        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
//         if (SceneManager.sceneCount > nextSceneIndex)
//         {
//             SceneManager.LoadScene(nextSceneIndex);
//         }

   }
}
