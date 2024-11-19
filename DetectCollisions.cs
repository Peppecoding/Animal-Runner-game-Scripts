using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
//  Destry the Animal and the Pizza collision
    private void OnTriggerEnter(Collider other)
    {
        Destroy (gameObject);
        Destroy (other.gameObject);
    }
}
