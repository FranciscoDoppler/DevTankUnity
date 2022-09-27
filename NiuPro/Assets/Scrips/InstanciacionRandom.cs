using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciacionRandom : MonoBehaviour
{
    public Transform pos;

    public GameObject[] objectsToInstatiate;
    void Start()
    {
        int n = Random.Range(0, objectsToInstatiate.Length);

        Instantiate(objectsToInstatiate[n], pos.position, objectsToInstatiate[n].transform.rotation);
    }
   
   
}
