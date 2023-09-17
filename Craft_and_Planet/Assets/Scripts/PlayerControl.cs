using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    
    private Vector3 velocity = Vector3.up * 0.01f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move the plane forward at a constant rate
        transform.Translate(velocity);
        
    }

    
}
