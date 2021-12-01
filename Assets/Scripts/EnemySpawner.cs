using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] monsterReference;

    [HideInInspector]
    public int count = 0;
    private int time = 0;

    private GameObject spawnedmonster;

    private int randomSide;
    private int randomIndex;

    [SerializeField]
    private Transform leftPos, rightPos;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonsters());

        
    }

    IEnumerator SpawnMonsters()
    {
        while (true)
        { 
        yield return new WaitForSeconds(Random.Range(1,5));
        randomIndex = Random.Range(0, monsterReference.Length);
        randomSide = Random.Range(0,2);

        spawnedmonster = Instantiate(monsterReference[randomIndex]);
        count++;

        if (randomSide == 0) //left
        {
            spawnedmonster.transform.position = leftPos.position;
            spawnedmonster.GetComponent<EnemyMovement>().speed = Random.Range(4, 10);

        }
        else //right side
        {
            spawnedmonster.transform.position = rightPos.position;
            spawnedmonster.GetComponent<EnemyMovement>().speed = -Random.Range(4, 10);
            spawnedmonster.transform.localScale = new Vector3(-1f, 1f, 1f);

            
        }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("You Survived "+count+" Bug Boys");
        //Debug.Log("You Survived for " + time + " seconds");
    }
}
