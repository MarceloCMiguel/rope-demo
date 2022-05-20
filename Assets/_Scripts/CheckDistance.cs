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
        listPositionRope1 = new List<Vector3>();
        listPositionRope2 = new List<Vector3>();
        InvokeRepeating(nameOf(checkDistance(2.0f,listPositionRope1,listPositionRope2)), 0,2);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    // every 2 seconds perform the print()
    private IEnumerator checkDistance(float waitTime, List<Vector3>listPositionRope1,List<Vector3>listPositionRope2 )
    {
        foreach (Transform child in rope1.transform){
            listPositionRope1.Add(child.position);
        }
        foreach (Transform child in rope2.transform){
            listPositionRope2.Add(child.position);
        }
        for(int i = 0; i < listPositionRope1.Count; i++){
            print(Vector3.Distance(listPositionRope1[i],listPositionRope2[i]));
        }
        yield return checkDistance(2.0f,listPositionRope1,listPositionRope2);
    
    }

}
