using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attraction : MonoBehaviour
{
    public GameObject craft;
    
    // Start is called before the first frame update
    private float attractPara;
    private float deltaAttPara;
    public Vector3 distanceVector;
    public Vector3 acceleration;
    private Rigidbody2D craftRigidbody;
    private int volumePara = 2;
    void Start()
    {
        craftRigidbody = craft.GetComponent<Rigidbody2D>();

        attractPara = transform.localScale.x * 10;
        deltaAttPara = transform.localScale.x * 4;
    }

    // Update is called once per frame
    void Update()
    {    
      

     
        
    }

    private void OnMouseDown()
    {
        if (volumePara < 7)
        {
            volumePara++;
            attractPara = attractPara + deltaAttPara;
            transform.localScale = transform.localScale + new Vector3(0.2f, 0.2f, 0f);
        }
        Debug.Log("add");
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (volumePara > 0)
            {
                attractPara = attractPara - deltaAttPara;
                transform.localScale = transform.localScale - new Vector3(0.2f, 0.2f, 0f);
                volumePara--;
            }
        }
    }

    public float getAttractPara()
    {
        return attractPara;
    }
}
