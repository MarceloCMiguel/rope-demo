using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRopePosition : MonoBehaviour
{
    public GameObject rope;
    private List<Vector3> listPositionRope1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(getPosition), 0,2);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void getPosition(){
        listPositionRope1 = new List<Vector3>();
        foreach (Transform child in rope.transform){
            listPositionRope1.Add(child.position);
        }
        var result = ListToText(listPositionRope1);
        print(result);
    }

    private string ListToText(List<Vector3> list)
 {
     string result = "";
     foreach(var listMember in list)
     {
         result += "new Vector3" +listMember.ToString() + "\n";
     }
     return result;
 }

}
