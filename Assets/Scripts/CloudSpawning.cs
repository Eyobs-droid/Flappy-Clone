using UnityEngine;

public class CloudSpawning : MonoBehaviour
{
    public GameObject clouds;
    public float spawnrate;
    private float timer;
    public float heightOffset;

    void Start()
    {
        spawnee();
    }


    void Update()
    {
        if (timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }

        else
        {
            spawnee();
            timer = 0;
        }

    }

    void spawnee()
    {

        float lowest = transform.position.y - heightOffset;
        float highest = transform.position.y + heightOffset;

        Instantiate(clouds, new Vector3(transform.position.x, Random.Range(lowest, highest), 0), transform.rotation);
    }
}
