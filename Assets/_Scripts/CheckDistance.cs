using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class CheckDistance : MonoBehaviour
{

    public GameObject rope1;

    private List<Vector3> listPositionRope1;
    private List<Vector3> listPositionRope2;
    // Start is called before the first frame update
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Level1"){
        listPositionRope2 = new List<Vector3>{new Vector3(6.7f, 0.7f, 0.0f),
new Vector3(6.4f, 0.6f, 0.0f),
new Vector3(6.0f, 0.7f, 0.0f),
new Vector3(5.8f, 0.4f, 0.0f),
new Vector3(5.7f, 0.2f, 0.0f),
new Vector3(5.6f, -0.1f, 0.0f),
new Vector3(5.4f, -0.3f, 0.0f),
new Vector3(5.3f, -0.5f, 0.0f),
new Vector3(5.2f, -0.7f, 0.0f),
new Vector3(5.0f, -1.0f, 0.0f),
new Vector3(4.8f, -1.2f, 0.0f),
new Vector3(4.6f, -1.4f, 0.0f),
new Vector3(4.4f, -1.6f, 0.0f),
new Vector3(4.1f, -1.6f, 0.0f),
new Vector3(3.8f, -1.6f, 0.0f),
new Vector3(3.6f, -1.6f, 0.0f),
new Vector3(3.3f, -1.6f, 0.0f),
new Vector3(3.0f, -1.5f, 0.0f),
new Vector3(2.7f, -1.4f, 0.0f),
new Vector3(2.4f, -1.4f, 0.0f),
new Vector3(2.1f, -1.5f, 0.0f),
new Vector3(1.8f, -1.6f, 0.0f),
new Vector3(1.5f, -1.7f, 0.0f),
new Vector3(1.3f, -1.7f, 0.0f),
        };
        }
        else if (scene.name == "Level2"){
            
        }
        
        InvokeRepeating(nameof(checkDistance), 0,1);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    // every 2 seconds perform the print()
    private void checkDistance()
    {
        
        listPositionRope1 = new List<Vector3>();
        
        foreach (Transform child in rope1.transform){
            listPositionRope1.Add(child.position);
        }
        
        double x = 0;
        bool y = true;
        for(int i = 0; i < listPositionRope1.Count; i++){
            double distance = Vector3.Distance(listPositionRope1[i],listPositionRope2[i]);
            x+= distance;
            print("--");
            if (distance > 0.6f){
                print(distance);
                y = false;
            } 
            // print(Vector3.Distance(listPositionRope1[i],listPositionRope2[i]));
        }
        print(y);
        print(x/listPositionRope1.Count);
    }

}
