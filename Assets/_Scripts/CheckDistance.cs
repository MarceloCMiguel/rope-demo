using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class CheckDistance : MonoBehaviour {

    public GameObject rope1;

    private List<Vector3> listPositionRopePlayer;
    private List<Vector3> listPositionRopeTemplate;
    GameManager gm;

    void Start() {
        gm = GameManager.GetInstance();
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Level1") {
            listPositionRopeTemplate = new List<Vector3> {
                new Vector3(6.6f,0.7f,0.0f),
                new Vector3(5.9f,0.6f,0.0f),
                new Vector3(5.5f,0.1f,0.0f),
                new Vector3(5.3f,-0.5f,0.0f),
                new Vector3(4.9f,-1.1f,0.0f),
                new Vector3(4.5f,-1.6f,0.0f),
                new Vector3(3.9f,-1.7f,0.0f),
                new Vector3(3.3f,-1.4f,0.0f),
                new Vector3(2.7f,-1.3f,0.0f),
                new Vector3(2.0f,-1.5f,0.0f),
            };
        }
        else if (scene.name == "Level2") {
            listPositionRopeTemplate = new List<Vector3> {
                new Vector3(1.7f,-1.2f,0.0f),
                new Vector3(1.6f,-0.5f,0.0f),
                new Vector3(1.3f,0.0f,0.0f),
                new Vector3(1.0f,0.6f,0.0f),
                new Vector3(0.7f,1.2f,0.0f),
                new Vector3(0.3f,1.7f,0.0f),
                new Vector3(-0.4f,1.7f,0.0f),
                new Vector3(-0.8f,1.1f,0.0f),
                new Vector3(-1.0f,0.6f,0.0f),
                new Vector3(-1.3f,0.0f,0.0f),
                new Vector3(-1.6f,-0.6f,0.0f),
            };
        }
        InvokeRepeating(nameof(checkDistance), 0,1);
    }

    // Update is called once per frame
    void Update() {
        
        
    }
    // every 2 seconds perform the print()
    private void checkDistance() {
        
        if(gm.passou ==false){
            
        listPositionRopePlayer = new List<Vector3>();
        
        foreach (Transform child in rope1.transform) {
            if (child.gameObject.tag == "RopeSeg"){
                listPositionRopePlayer.Add(child.position);
            }
        }
        
        double x = 0;
        bool y = true;
        // for (int i = 0; i < listPositionRopePlayer.Count; i++){
        //     double distance = Vector3.Distance(listPositionRopePlayer[i], listPositionRopeTemplate[i]);
        //     x += distance;
        //     print("--");
        //     if (distance > 0.6f){
        //         print(distance);
        //         y = false;
        //     } 
        //     // print(Vector3.Distance(listPositionRopePlayer[i],listPositionRopeTemplate[i]));
        // }
        for (int i = 0; i < listPositionRopeTemplate.Count; i++){
            double minDistance = Vector3.Distance(listPositionRopePlayer[0], listPositionRopeTemplate[i]);;
            for (int j = 1; j < listPositionRopePlayer.Count; j++){
                double distance = Vector3.Distance(listPositionRopePlayer[j], listPositionRopeTemplate[i]);
                if (distance < minDistance){
                    minDistance = distance;
                }
            } 
            x += minDistance;
            print("--");
            if (minDistance > 0.6f){
                print(minDistance);
                y = false;
            }
            // print(Vector3.Distance(listPositionRopePlayer[i],listPositionRopeTemplate[i]));
        }
        print(y);
        print(x/listPositionRopePlayer.Count);
        if (y){
            gm.passou = y;
            // gm.NextScene();
        }
        gm.distance = x/listPositionRopePlayer.Count;
    }
    
        }

}
