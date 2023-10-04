using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float speedPlayer = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2( horizontalInput * speedPlayer * Time.deltaTime, 0);
        transform.Translate(movement); 
        if (horizontalInput < 0) {
            GetComponent<SpriteRenderer>().flipX = true;
        } else if(horizontalInput > 0) { GetComponent<SpriteRenderer>().flipX = false; }
        
    }
}
