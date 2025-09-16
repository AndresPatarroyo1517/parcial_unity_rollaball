using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboRojo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            transform.position += new Vector3(-1f, 0f, 0f);
        }
    }
}
