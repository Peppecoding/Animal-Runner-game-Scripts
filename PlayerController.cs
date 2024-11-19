using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float HorizontalInput;
    public float Speed = 10.0f; 

    public float xRange = 10.0f;

    public GameObject ProjectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        Barrier();
        Movement();
        Fire();

    }

    private void Fire()
    {
      if (Input.GetKeyDown(KeyCode.Space))
    {
    Instantiate(ProjectilePrefab, transform.position, ProjectilePrefab.transform.rotation);
    }

    }

    private void Movement()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * Speed);
    }

    private void Barrier()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}