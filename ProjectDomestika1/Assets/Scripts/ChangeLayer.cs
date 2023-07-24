using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<SpriteRenderer>().color = Color.red;
        Debug.Log("è partito lo script ChangeLayer! ");
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)){
            Debug.Log("Hai premuto W");
            SpriteRenderer spriteRenderer = this.GetComponent<SpriteRenderer>();
            spriteRenderer.sortingOrder = 2;


        }

        if(Input.GetKeyDown(KeyCode.S)){
            Debug.Log("Hai premuto S");
            SpriteRenderer spriteRenderer = this.GetComponent<SpriteRenderer>();
            spriteRenderer.sortingOrder = 0;
       
            
        }
    }
}
