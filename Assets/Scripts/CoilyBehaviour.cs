using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.Events;

public class CoilyBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public static float counter = 50;
    //private float counter2 = 0;
    public GameObject PlayerPosition;
    private Vector2 movement;
    private Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = PlayerPosition.transform.position;// - transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        
        counter++;
        Debug.Log(direction);
        if (counter == 100)
        {
            
            if (direction.y > transform.position.y &&
                direction.x > transform.position.x)
            {
                transform.position += new Vector3(0.6f, 1.0f);
                Debug.Log("Up-Right!");
            }
            else if (direction.y > transform.position.y &&
                     direction.x < transform.position.x)
            {
                transform.position += new Vector3(-0.6f, 1.0f);
                Debug.Log("Up-Left!");
            }
            else if (direction.y < transform.position.y &&
                     direction.x > transform.position.x)
            {
                transform.position += new Vector3(0.6f, -1.0f);
                Debug.Log("Down-Left!");
            }
            else if (direction.y < transform.position.y &&
                     direction.x < transform.position.x)
            {
                transform.position += new Vector3(-0.6f, -1.0f);
                Debug.Log("Down-Right!");
            }

            direction = PlayerPosition.transform.position;

            counter = 50;
        }
        //counter2++;
        //if (counter2 == 100)
        //{
        //    if (PlayerPosition.position.y > transform.position.y)
        //    {
        //        transform.position += new Vector3(-0.6f, 1.0f);
        //        counter2 = 0;
        //    }
        //    else if (PlayerPosition.position.y < transform.position.y)
        //    {
        //        transform.position += new Vector3(-0.6f, -1.0f);
        //        counter2 = 0;
        //    }
        //}
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Border")
        {
            transform.position = new Vector3(-0.7f, 3);
            WinCheck.Score += 500;
        }
        if(collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.position = new Vector3(-0.2f, 4.1f);
            WinCheck.Lives -= 1;
        }
    }
}
