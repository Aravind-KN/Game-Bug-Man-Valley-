using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Transform player;
    private Vector3 tempPos;

    [SerializeField]
    private float minX=-47.129f, maxX=46.683f;

    private float k; //using this for temp.Pos.x because that aint workie
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform; //finds gameobjects with tag "Player" and gives its transform(pos) ( i.e Player_0 object)     
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (player == null)
        {
            return;
        }
        tempPos = transform.position; //current pos of camera
        tempPos.x = player.position.x; //set camera pos to player' pos
        k = tempPos.x;

        if (k < minX)
            tempPos.x = minX;
        if (k > maxX)
            tempPos.x = maxX;
        
        transform.position = tempPos;
        
    }
}