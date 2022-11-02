using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisablePowerup : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            PowerupManager.instance.EndPowerup();
            Destroy(gameObject);
        }
    }
}
