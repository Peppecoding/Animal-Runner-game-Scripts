using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float TopBound = 30;
    private float LowerBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //  if an object pass the player the game will be over
        if(transform.position.z > TopBound)
        {
            Destroy(gameObject);
        } 
        else if(transform.position.z < LowerBound)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        };
    }
}
