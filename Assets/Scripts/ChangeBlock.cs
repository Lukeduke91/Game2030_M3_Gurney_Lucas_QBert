using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeBlock : MonoBehaviour
{
    public Sprite otherSprite;

    

    // Start is called before the first frame update
    void Start()
    {
        //spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(GetComponent<SpriteRenderer>().sprite != otherSprite)
            {
                WinCheck.CheckingWin -= 1;
                WinCheck.Score += 25;
                Debug.Log(WinCheck.CheckingWin);
            }
            GetComponent<SpriteRenderer>().sprite = otherSprite;
            
        }
    }
}
