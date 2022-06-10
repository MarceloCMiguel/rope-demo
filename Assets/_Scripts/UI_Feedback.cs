using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UI_Feedback : MonoBehaviour
{
    Text textComp;
    GameManager gm;
    bool passou_fase;
    // Start is called before the first frame update
    void Start()
    {
        passou_fase = false;
        gm = GameManager.GetInstance();
        textComp = GetComponent<Text>();
        textComp.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (passou_fase == false && gm.passou == true){
            passou_fase = true;
            
            
            StartCoroutine(WaitAndGo(1.0f));
        
            
        }
    }

     // every 2 seconds perform the print()
    private IEnumerator WaitAndGo(float waitTime)
    {
        textComp.enabled = true;
        yield return new WaitForSeconds(waitTime);
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Menu") {
            gm.GoToScene("EasterEgg");
        }
        else if (scene.name == "EasterEgg") {
            gm.GoToScene("Menu");
        }
        else {
            gm.NextScene();
        }
        
        
        
    }
}
