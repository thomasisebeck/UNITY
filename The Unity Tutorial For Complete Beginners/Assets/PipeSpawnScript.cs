using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;

    public float spawnRate;
    private float timer;
    public float maxOffset;

    private void spawnPipe()
    {
        float randomOffset = Random.Range(maxOffset * -1, maxOffset); 
        Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y + randomOffset, transform.position.z);
        Instantiate(pipe, spawnPosition, transform.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        timer = spawnRate;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
            timer += Time.deltaTime;
        else
        {
            timer = 0;
            spawnPipe();
        }
    }
}
