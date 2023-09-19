using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public GameObject craft;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private Vector3 offset = new Vector3(1, 3, 0);
    // Update is called once per frame
    void LateUpdate()
    {
        //if (transform.position.y - craft.transform.position.y > 5) transform.Translate(new Vector3(0f,-10f,0f));
        // if (craft.transform.position.y - transform.position.y > 5) transform.Translate(new Vector3(0f, 10f, 0f));

        if (craft.transform.position.y >= 0 && craft.transform.position.y <= 20) transform.position = craft.transform.position.y* (new Vector3(0f, 1f, 0f)) + new Vector3(0f, 0f, -10f); ;
       
    }
}
