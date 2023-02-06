using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public GameObject[] section;
    public int zPos = 50;
    public bool creatingSection = false;
    public int secum;

    
    void Update()
    {


        if (creatingSection == false)
        {

            creatingSection = true;
              StartCoroutine(GenerateSection());
        }
    }
    IEnumerator GenerateSection()
    {
        secum = Random.Range(0, 3);
        Instantiate(section[secum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 50;

        yield return new WaitForSeconds(1);
        creatingSection = false;
    }
    
}
