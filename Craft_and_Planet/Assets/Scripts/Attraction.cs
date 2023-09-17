using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attraction : MonoBehaviour
{
    public GameObject craft;
    
    // Start is called before the first frame update
    private float attractPara = 5.0f;
    public Vector3 distanceVector;
    public Vector3 acceleration;
    private Rigidbody2D craftRigidbody;
    private int volumePara = 5;
    void Start()
    {
        craftRigidbody = craft.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {    
      

        if (craftRigidbody != null)
        {
            // 计算吸引力方向
            Vector3 distanceVector = transform.position - craft.transform.position;
            float distance = distanceVector.magnitude;
            Vector3 attractionDirection = distanceVector.normalized;

            // 计算吸引力大小
            float attractionForce = attractPara / distance ;

            // 把吸引力加到刚体上
            craftRigidbody.AddForce(attractionDirection * attractionForce );

           // Debug.Log("Distance Vector: " + distance);
           
           // Debug.Log("Attraction Force: " + attractionForce);
        }
        
    }

    private void OnMouseDown()
    {
        if (volumePara < 10)
        {
            volumePara++;
            attractPara = attractPara + 2.50f;
            transform.localScale = transform.localScale + new Vector3(0.2f, 0.2f, 0f);
        }
        Debug.Log("add");
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (volumePara > 3)
            {
                attractPara = attractPara - 2.50f;
                transform.localScale = transform.localScale - new Vector3(0.2f, 0.2f, 0f);
                volumePara--;
            }
        }
    }
}
