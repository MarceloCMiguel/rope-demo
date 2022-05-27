using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetRopePosition : MonoBehaviour {
    public GameObject rope;
    private List<Vector3> listPositionRope1;

    void Start() {
        InvokeRepeating(nameof(getPosition), 0,2);
        
    }


    void Update() {
        
    }

    private void getPosition() {
        listPositionRope1 = new List<Vector3>();
        foreach (Transform child in rope.transform){
            listPositionRope1.Add(child.position);
        }
        var result = ListToText(listPositionRope1);
        print(result);
    }

    private string ListToText(List<Vector3> list) {
        string result = "";
        foreach(var listMember in list) {
            string nodeX = listMember[0].ToString("N1");
            string nodeY = listMember[1].ToString("N1");
            string nodeZ = listMember[2].ToString("N1");
            result += "new Vector3(" + nodeX.Replace(",", ".") + "f," + nodeY.Replace(",", ".") + "f," + nodeZ.Replace(",", ".") + "f)," + "\n";
        }
    return result;
    }
}

