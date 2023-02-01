using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    public Transform[] spawnPoints;
    public GameObject block;
    public float hi = 1f;
    private float B = 2f;
    
    void Update()
    {
        if (Time.time >= B)
        {
            Spawnground();
            B = Time.time + hi;

        }
        transform.position = player.position + offset;
    }
    void Spawnground()
    {
       
    }
}
