using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    public float m_Speed = 10f;
    public Vector3 newPosition;
    public Vector3 startPosition;

    private bool hit = false;
    private float flashSpeed = 0.12f;
    CircleCollider2D playerCollider;


    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
        playerCollider = GetComponent<CircleCollider2D>();
    }

    void Update()
    {
    }

    void FixedUpdate(){
        Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0);
        newPosition = transform.position + m_Input * Time.deltaTime * m_Speed;
        Vector2 posicaoViewport = Camera.main.WorldToViewportPoint(newPosition);
        if (posicaoViewport.x>=0 && posicaoViewport.x<=1 && posicaoViewport.y<=1 && posicaoViewport.y>=0){
            m_Rigidbody.MovePosition(newPosition);
        }  
    }
}
