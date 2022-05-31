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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(){
        print("a");
        gm.GoToScene("Level1");
    }
}
