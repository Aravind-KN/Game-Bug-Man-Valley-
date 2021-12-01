using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [HideInInspector]
    public float speed;

    private Rigidbody2D myBody;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        //speed = 7;
    }

    // Update is called once per frame
    void Update()
    {
        myBody.velocity = new Vector2(speed, myBody.velocity.y); //y velocity is zero anyways
        //Debug.Log("You survived " + spawnedmonster.GetComponent<EnemySpawner>().count);
    }
}
