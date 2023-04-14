using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HopTo : MonoBehaviour
{
    public GameObject LifeSymbol;
    public GameObject LifeSymbol2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("1"))
        {
            transform.position += new Vector3(-0.6f, -1.0f);
        }

        if (Input.GetKeyDown("3"))
        {
            transform.position += new Vector3(0.6f, -1.0f);
        }

        if (Input.GetKeyDown("7"))
        {
            transform.position += new Vector3(-0.6f, 1.0f);
        }

        if (Input.GetKeyDown("9"))
        {
            transform.position += new Vector3(0.6f, 1.0f);
        }

        if (WinCheck.Lives == 2)
        {
            Destroy(LifeSymbol);
        }
        if (WinCheck.Lives == 1)
        {
            Destroy(LifeSymbol2);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Border")
        {
            transform.position = new Vector3(-0.2f, 4.1f);
            WinCheck.Lives -= 1;
            
        }
    }
}
