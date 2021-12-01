using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform myTransform;

    void Start()
    {
        myTransform = transform;
        myTransform.position = new Vector2(3,1);
    }

}
