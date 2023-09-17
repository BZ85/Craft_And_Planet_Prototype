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

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y - craft.transform.position.y > 5) transform.Translate(new Vector3(0f,-10f,0f));
        if (craft.transform.position.y - transform.position.y > 5) transform.Translate(new Vector3(0f, 10f, 0f));
    }
}
