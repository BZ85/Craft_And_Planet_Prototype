using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTarget : MonoBehaviour
{
    public GameObject winText;
    public GameObject background;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        //game win
        if (collision.gameObject.name == "Craft")
        {
            winText.SetActive(true);
            background.SetActive(true);
            Debug.Log("Win");
        }
    }
}
