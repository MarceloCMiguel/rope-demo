using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Start : MonoBehaviour
{
    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        
        gm = GameManager.GetInstance();
        gm.scene_index = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(){
        gm.GoToScene("Level1");
    }
}
