using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Obstacle : MonoBehaviour
{

    public GameObject craft;
   
    public TextMeshProUGUI HealthText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){    
        
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Craft")
        {

            print("obstacle collision");
            craft.GetComponent<PlayerControl>().health = craft.GetComponent<PlayerControl>().health - 1;
            HealthText.text = "Health: " + craft.GetComponent<PlayerControl>().health;
            if (craft.GetComponent<PlayerControl>().health == 0)
            {
                // print("Game over");
                

            }
           // print(craft.GetComponent<PlayerControl>().health);
        }
    }
}
