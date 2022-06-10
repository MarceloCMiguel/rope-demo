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
   public int scene_index;
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
       SceneManager.LoadScene("Menu");
       passou = false;
       distance = 10;
       scene_index = 1;
       gameState = GameState.MENU;
   }

   public void NextScene(){
       
       if (scene_index + 1 <SceneManager.sceneCountInBuildSettings){
           scene_index +=1;
           SceneManager.LoadScene(scene_index);
           passou = false;
           distance = 10;
       }
       else{
           SceneManager.LoadScene("Menu");
           passou = false;
           distance = 10;
       }

   }

    public void GoToScene(string scene_name){
        passou = false;
        SceneManager.LoadScene(scene_name);
    }

       
//        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
//         if (SceneManager.sceneCount > nextSceneIndex)
//         {
//             SceneManager.LoadScene(nextSceneIndex);
//         }

   
}
