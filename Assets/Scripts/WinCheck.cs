using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCheck : MonoBehaviour
{
    public static int CheckingWin = 28;
    public static int Lives = 3;
    public static int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CheckingWin == 0)
        {
            Debug.Log("Victory!!");
            Score += 1000;
            StartCoroutine(loadLeaderBoard());
            if (Teleport.TeleporterCounter == 2)
            {
                Score += 200;
            }
            else if (Teleport.TeleporterCounter == 1)
            {
                Score += 100;
            }
            else if (Teleport.TeleporterCounter == 0)
            {
                Score += 0;
            }
            Debug.Log(Score);
        }
        if(Lives == 0)
        {
            Lives = 3;
            SceneManager.LoadScene(0);
        }
        
    }

    IEnumerator loadLeaderBoard()
    {
        CheckingWin = 28;
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(2);
    }
}
