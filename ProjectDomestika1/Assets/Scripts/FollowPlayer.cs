using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Vector2 position = new Vector2(Player.transform.position.x, 0);
        Vector3 distance = new Vector3(Player.transform.position.x, 0 ,-5);
        this.transform.position =  distance; 
    }
}
