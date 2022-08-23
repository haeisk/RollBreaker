using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;   
    public float jumpforce;

    void Start()
    {
        rb.AddForce(Vector3.up * -jumpforce);
        
    }

    void update()
    {
     


    }

    private void OnCollisionEnter(Collision other)
    {
        //

        string materialName = other.gameObject.GetComponent<MeshRenderer>().material.name;
        Debug.Log("Materyal Adi:" + materialName);

        
        if(materialName == "Floor (Instance)")
        {
            rb.AddForce(Vector3.up * (jumpforce * 2));
        }
        if (materialName == "Floor2 (Instance)")
        {
            rb.AddForce(Vector3.up * (jumpforce * 0));

        }

        if (materialName == "Brick (Instance)" || materialName == "Toop (Instance)" || materialName == "Brick1 (Instance)")
        {
            rb.AddForce(Vector3.up * (jumpforce * -2));

        }

      
        
        
    }
   
}
