using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTarget : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Craft")
        {
            text.SetActive(true);
            Debug.Log("Collide");
        }
    }
}
