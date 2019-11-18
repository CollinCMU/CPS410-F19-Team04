using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathzone : MonoBehaviour
{

    public Transform spawn;

    void OnTriggerEnter2D(Collider2D player)
    {
        player.transform.position = spawn.position;
    }

}
