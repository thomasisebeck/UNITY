using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{

    public GameObject myPipePrefab;
    public int spawnInterval; 

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreatePipe", 5, spawnInterval);
    }

    void CreatePipe()
    {
        Instantiate(myPipePrefab, new Vector3(33,0,0), Quaternion.identity); //identity rotation
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
