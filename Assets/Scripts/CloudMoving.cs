using UnityEngine;

public class CloudMoving : MonoBehaviour
{
    public GameObject cloud;
    public float movingspeed;
    private float Dead = -90;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left) * movingspeed * Time.deltaTime;

        if (transform.position.x < Dead)
        {
            Destroy(gameObject);
        }
    }
}
