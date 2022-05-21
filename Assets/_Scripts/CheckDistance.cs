using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDistance : MonoBehaviour
{

    public GameObject rope1;
    public GameObject rope2;

    private List<Vector3> listPositionRope1;
    private List<Vector3> listPositionRope2;
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating(nameof(checkDistance), 0,2);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    // every 2 seconds perform the print()
    private void checkDistance()
    {
        listPositionRope1 = new List<Vector3>();
        listPositionRope2 = new List<Vector3>();
        foreach (Transform child in rope1.transform){
            listPositionRope1.Add(child.position);
        }
        foreach (Transform child in rope2.transform){
            listPositionRope2.Add(child.position);
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
