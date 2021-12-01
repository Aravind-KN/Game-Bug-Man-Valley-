using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float moveForce = 10f;

    private float movementX;
    //private SpriteRenderer sr;
    //private Animator anim;
    public  Rigidbody2D mybody; // for attaching component of player_0


    void Start()
    {

    }

    void update()
    {
        PlayerMoveKeyboard();

     
    }

    void PlayerMoveKeyboard()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX, 0f, 0f) * moveForce * Time.deltaTime;
        Debug.Log(movementX);
       
    
    }
}
