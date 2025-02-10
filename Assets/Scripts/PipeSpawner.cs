using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate;
    private float timer;
    public float heightOffset;

    void Start()
    {
        spawning();
    }

    
    void Update()
    {
        if (timer < spawnrate)
        {
            timer  = timer + Time.deltaTime;
        }

        else
        {
            spawning();
            timer = 0;
        }
       
    }

     void spawning()
    {

        float lowestpoint = transform.position.y - heightOffset;
        float highestpoint = transform.position.y + heightOffset;
        
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0), transform.rotation);
    }
}
