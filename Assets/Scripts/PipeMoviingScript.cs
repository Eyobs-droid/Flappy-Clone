using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PipeMoviingScript : MonoBehaviour
{
    public float moveSpeed;
    private float Deadzone = -90;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < Deadzone)
        { 
            Destroy(gameObject);
        }
    }
}
