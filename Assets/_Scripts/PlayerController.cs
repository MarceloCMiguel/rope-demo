using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    Rigidbody2D m_Rigidbody;
    private float m_Speed = 120f;
    public Vector3 newPosition;
    public Vector3 startPosition;
    private bool hit = false;
    CircleCollider2D playerCollider;
    GameManager gm;

    void Start() {
        gm = GameManager.GetInstance();
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody2D>();
        startPosition = transform.position;
        playerCollider = GetComponent<CircleCollider2D>();
    }   

    
    void Update() {
        
        if (Input.GetKeyDown(KeyCode.Escape) && !gm.get_gamestatepause())
        {
            gm.setgamestate_pause();
            Time.timeScale = 0;
            SceneManager.LoadScene("Pause",  LoadSceneMode.Additive);
        }
        
        
        float horizontalController = Input.GetAxis("Controller 1 Horizontal");
        float verticalController = Input.GetAxis("Controller 1 Vertical");
        float horizontalKey = Input.GetAxis("Horizontal 1");
        float verticalKey = Input.GetAxis("Vertical 1");
        float horizontal = horizontalController + horizontalKey;
        float vertical = verticalController + verticalKey;
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
