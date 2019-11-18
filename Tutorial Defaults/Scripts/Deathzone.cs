using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathzone : MonoBehaviour
{

    public Transform spawn;

    void OnTriggerEnter2D(Collider2D player)
    {
        wait(5);
        player.transform.position = spawn.position;
    }

    IEnumerator wait(int time)
    {
        yield return new WaitForSecondsRealtime(time);
    }

}
