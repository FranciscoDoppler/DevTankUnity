using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruir : MonoBehaviour
{
    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "Balas")
        {
            Destroy(gameObject);
        }
    }
}
