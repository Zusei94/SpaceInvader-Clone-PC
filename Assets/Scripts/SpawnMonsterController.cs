using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonsterController : MonoBehaviour
{
    public GameObject monster1;
    public GameObject monster2;
    public GameObject monster3;
    public float startInterval = 2;
    public float interval = 3;

    void Start()
    {
        InvokeRepeating("SpawnMonster", startInterval, interval);
    }

    private void SpawnMonster()
    {
        float myRan = Random.value;
        if (myRan < 0.1)
        {
            GameObject g = Instantiate(monster1, transform.position, Quaternion.identity);
        }
        else if (myRan <0.2)
        {
            GameObject g = Instantiate(monster2, transform.position, Quaternion.identity);
        }
        else if (myRan < 0.4)
        {
            GameObject g = Instantiate(monster3, transform.position, Quaternion.identity);
        }
        else
        {
            //nothing
        }
            
    }
}
