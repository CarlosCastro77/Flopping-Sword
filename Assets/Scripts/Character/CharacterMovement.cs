using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    Rigidbody2D characterBody;
    public GameObject gameOver;

    void Start()
    {
        characterBody = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Control();
    }
    
    void Control()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            characterBody.AddForce(Vector2.up, ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
     if (collision.gameObject.tag == "Wall")
        {
            this.enabled = false;
            gameOver.SetActive(true);
        }   
    }
}
