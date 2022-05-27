using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_Indicativo : MonoBehaviour
{
    Text textComp;
    GameManager gm;
    private string indicativo;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.GetInstance();
        textComp = GetComponent<Text>();
        indicativo = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.passou){
            indicativo = "CHEGOU";
            textComp.color = Color.yellow;
        }
        else if(gm.distance >2.5f){
            indicativo = "FRIO";
            textComp.color = Color.blue;
        }
        else if(gm.distance>1){
            indicativo = "ESQUENTANDO";
            textComp.color = new Color32(0xFF,0xA5,0x00,0xFF);
        }
        else{
            indicativo = "QUENTE";
            textComp.color = Color.red;
        }
        textComp.text = $"{indicativo}";
        
        
    }
}
