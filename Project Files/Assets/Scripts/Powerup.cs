using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag == "Player")
        {
            PowerupManager.instance.StartPowerup();
            Destroy(gameObject);
        }
    }
}
