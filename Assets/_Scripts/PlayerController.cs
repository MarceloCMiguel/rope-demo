using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    Rigidbody2D m_Rigidbody;
    private float m_Speed = 5f;
    public Vector3 newPosition;
    public Vector3 startPosition;

    private bool hit = false;
    CircleCollider2D playerCollider;


    void Start() {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
        playerCollider = GetComponent<CircleCollider2D>();
    }

    void Update() {
    }

    void FixedUpdate() {
        float horizontal = Input.GetAxis("Controller 1 Horizontal");
        float vertical = Input.GetAxis("Controller 1 Vertical"); 
        // if (Input.GetKey(KeyCode.A))
        //     horizontal += -1 ;

        // if (Input.GetKey(KeyCode.D))
        //     horizontal += 1 ;
        // if (Input.GetKey(KeyCode.W))
        //     vertical += 1;
        // if (Input.GetKey(KeyCode.S))
        //     vertical += -1;

        Vector3 m_Input = new Vector3(horizontal,vertical,1);
        newPosition = transform.position + m_Input * Time.deltaTime * m_Speed;
        m_Rigidbody.MovePosition(newPosition);


    }
}
