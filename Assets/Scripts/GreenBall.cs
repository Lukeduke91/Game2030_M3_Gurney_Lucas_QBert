using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            transform.position = new Vector3(-0.7f, 3);
            WinCheck.Score += 100;
            EnemyHopTo.counter = -100;
            EnemyHopTo.counter2 = -150;
            CoilyBehaviour.counter = -150;
        }
    }
}
