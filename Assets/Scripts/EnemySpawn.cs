using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    //public Transform Player;
    public Transform Blob;
    public Transform Blob2;
    public GameObject Coily;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(Player, new Vector2(-0.09f, 4.38f), Player.rotation);
        StartCoroutine(spawnBlob());
        StartCoroutine(spawnBlob2());
        StartCoroutine(spawnCoily());
    }

    IEnumerator spawnBlob()
    {
        yield return new WaitForSeconds(3);
        Instantiate(Blob, new Vector2(-0.7f, 3), Blob.rotation);
    }

    IEnumerator spawnBlob2()
    {
        yield return new WaitForSeconds(5);
        Instantiate(Blob2, new Vector2(0.7f, 3), Blob2.rotation);
    }

    IEnumerator spawnCoily()
    {
        yield return new WaitForSeconds(7);
        Instantiate(Coily, new Vector2(0.7f, 3), Blob2.rotation);
        
    }
}
