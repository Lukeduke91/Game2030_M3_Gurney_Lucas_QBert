using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CoilyBallHopTo : MonoBehaviour
{
    // Start is called before the first frame update
    private float counter = 50;
    private float counter2 = 0;
    public Transform Coily2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        counter++;
        if (counter == 100)
        {
            transform.position += new Vector3(-0.6f, -1.0f);
            counter = 0;
        }
        counter2++;
        if (counter2 == 100)
        {
            transform.position += new Vector3(0.6f, -1.0f);
            counter2 = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Border")
        {
            transform.position = new Vector3(-0.7f, 3);
            Coily2.gameObject.active = true;
            Destroy(this.gameObject);
        }
    }
}
