using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public static int TeleporterCounter = 2;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.position = new Vector2(-0.2f, 4.1f);
        Destroy(this.gameObject);
        TeleporterCounter--;
    }
}
