using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2Controller : MonoBehaviour {
    Rigidbody2D m_Rigidbody;
    private float m_Speed = 5f;
    public Vector3 newPosition;
    public Vector3 startPosition;

    private bool hit = false;
    private float flashSpeed = 0.12f;
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
        float horizontal = Input.GetAxis("Controller 2 Horizontal");
        float vertical = Input.GetAxis("Controller 2 Vertical"); 
        // if (Input.GetKey(KeyCode.LeftArrow)){
        //     //  m_Rigidbody.AddForce(Vector3.left*m_Speed);
        //     horizontal += -1 ;
        // }
        //  if (Input.GetKey(KeyCode.RightArrow))
        //     horizontal += 1 ;
        //     //  m_Rigidbody.AddForce(Vector3.right*m_Speed);
        //  if (Input.GetKey(KeyCode.UpArrow))
        //     vertical += 1;
        //     //  m_Rigidbody.AddForce(Vector3.up*m_Speed);
        //  if (Input.GetKey(KeyCode.DownArrow))
        //     vertical += -1;
            //  m_Rigidbody.AddForce(Vector3.down*m_Speed);
        // Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0);
        // newPosition = transform.position + m_Input * Time.deltaTime * m_Speed;
        // Vector2 posicaoViewport = Camera.main.WorldToViewportPoint(newPosition);
        // if (posicaoViewport.x>=0 && posicaoViewport.x<=1 && posicaoViewport.y<=1 && posicaoViewport.y>=0){
        Vector3 m_Input = new Vector3(horizontal,vertical,1);
        newPosition = transform.position + m_Input * Time.deltaTime * m_Speed;
        m_Rigidbody.MovePosition(newPosition);
        // }  
    }
}
