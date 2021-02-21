using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private GameObject capsule;
    private Vector3 number;
    List<GameObject> liste = new List<GameObject>();
    private float timer = 0;

    void Start()
    {
        
    }

    void Update()
    {
        Spawn();
    }
    
    private void Spawn()
    {
        timer = timer + 1 * Time.deltaTime;
        if (timer > 1)
        {
            number = new Vector3( Random.Range(6,-23),0,Random.Range(6,-24));
            capsule = (GameObject) Instantiate(Resources.Load("Rick Variant 1"), number, Quaternion.identity);
            liste.Add(capsule);
            timer = 0;
        }
    }
}