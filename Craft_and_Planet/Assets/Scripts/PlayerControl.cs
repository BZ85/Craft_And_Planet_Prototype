using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> characters = new List<GameObject>();
    public GameObject planet;

    private Vector3 velocity = Vector3.up;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move the plane forward at a constant rate
        //transform.Translate(velocity);


        for(int i=0;i<characters.Count;i++)
        {
            Vector3 distanceVector = characters[i].transform.position - transform.position;
            float distance = distanceVector.magnitude;
            Vector3 attractionDirection = distanceVector.normalized;

            float attractPara = characters[i].GetComponent<Attraction>().getAttractPara();
            print(attractPara);
            // 
            float attractionForce = attractPara/10.0f * 0.001f * 1 / distance;
            velocity = velocity + attractionForce * attractionDirection; 
        }

        float z = 0.0f;
        if (velocity.x > 0)
        {
            z = -Vector3.Angle(Vector3.up, velocity);
        }
        else
        {
            z = Vector3.Angle(Vector3.up, velocity);
        }

        transform.eulerAngles = new Vector3( .0f, .0f, z);

        transform.position = transform.position + velocity * Time.deltaTime;
    }

    
}
