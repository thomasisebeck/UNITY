using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    //reference to prefab, filled slot in prefab
    public GameObject myPipePrefab;
    public int spawnDelay;
    private float timer = 0;
    private float randomDelay = 1; 

    void CreatePipe()
    {
        //create a random offset
        float randomYOffset = Random.Range(-10.0f, 8.6f);
        Vector3 spawnPosition = new Vector3(transform.position.x, randomYOffset);

        //spawn the prefab with the original position and rotation
        Instantiate(myPipePrefab, spawnPosition, transform.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        CreatePipe(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnDelay + randomDelay)
        {
            timer += Time.deltaTime; //add time to the timer if less than spawnrate
            return;
        }

        //reset to 0 and spawn a pipe
        timer = 0;
        randomDelay = Random.Range(0, 4);
        CreatePipe();
    }
}
