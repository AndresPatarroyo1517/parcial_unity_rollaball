using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboAmarillo : MonoBehaviour
{
    public Transform verde;

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
            other.transform.position = verde.position;
        }
    }
}
