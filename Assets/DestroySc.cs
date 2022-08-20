using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySc : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject, 0f);
    }
    
}
