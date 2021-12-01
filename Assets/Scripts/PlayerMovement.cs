using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10000;

   
    private string WALK_ANIMATION = "Walk";
    private string jump = "Jump";

    [SerializeField]
    private Animator anim;
    private float h;

    [SerializeField]
    private SpriteRenderer sr;

    [SerializeField]
    private Rigidbody2D mybody;

    private float jumpForce = 10f;

    private bool isGrounded=true;
    private string Ground_tag = "Ground";

    private string Enemy_tag = "Enemy";
    private void Awake()
    {
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        mybody = GetComponent<Rigidbody2D>();

    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    void FixedUpdate()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        
        movement();
        AnimatePlayer();
        Playerjump();


    }

    void movement()
    {
        h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector2 pos = transform.position;

        pos.x += h * speed * Time.deltaTime;
        
        transform.position = pos;
    }

    void AnimatePlayer()
    {
        if (h > 0) //right side
        {
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = false;
        }
        else if (h < 0) //left side
        {   
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = true;
        }
        else
        {
            anim.SetBool(WALK_ANIMATION, false);
        }
    }

    void Playerjump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded = false;
            
            mybody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) //parameter is the player_0(second object for colliding)
    {
        if (collision.gameObject.CompareTag(Ground_tag))
        {
            isGrounded = true;
            
        }
        if (collision.gameObject.CompareTag(Enemy_tag))
        {
            Debug.Log("YOU DIED");
            Destroy(gameObject);
            
        }
    }

    
}