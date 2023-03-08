using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRididBody;
    public float flapStrength;
    private LogicScript logic;
    bool isAlive = true;
    
    // Start is called before the first frame update
    void Start()
    {
        myRididBody.constraints = RigidbodyConstraints2D.FreezeRotation;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void die()
    {
        isAlive = false;
        logic.gameOver();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
            myRididBody.velocity = Vector2.up * flapStrength;

        if (gameObject.transform.position.y < -15 || gameObject.transform.position.y > 15)
            die();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        die();
    }
}
