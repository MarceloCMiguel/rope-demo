using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRope : MonoBehaviour
{
    public Rigidbody2D player1;
    public GameObject player2;
    public GameObject ropeSeg;
    public int numLinks = 5;
    // Start is called before the first frame update
    void Start()
    {
        GenerateRope();
    }

    void GenerateRope(){
        Rigidbody2D prevBody = player1;
        for(int i = 0; i < numLinks; i++){
            GameObject newSeg = Instantiate(ropeSeg);
            newSeg.transform.parent = transform;
            newSeg.transform.position = transform.position;
            HingeJoint2D hj = newSeg.GetComponent<HingeJoint2D>();
            hj.connectedBody = prevBody;

            prevBody = newSeg.GetComponent<Rigidbody2D>();
        }
        GameObject lastSeg = Instantiate(player2);
        lastSeg.transform.parent = transform;
        lastSeg.transform.position = transform.position;
        HingeJoint2D p2hj = lastSeg.GetComponent<HingeJoint2D>();
        p2hj.connectedBody = prevBody;
    }
}
