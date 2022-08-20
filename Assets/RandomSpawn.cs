using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject Obstacle;    


    private void Start()
    {
        float randomy = Random.Range(0, 6);
        
        Obstacle.transform.position += new Vector3(0, randomy, 0);
    }
}
