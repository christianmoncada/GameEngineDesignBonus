using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupManager : MonoBehaviour
{
    public static PowerupManager instance;

    public bool powerupCheck = false;

    // Start is called before the first frame update
    void Awake()
    {
        if(!instance)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartPowerup()
    {
        powerupCheck = true;
        PlayerController.instance.IncreaseSpeed();
    }

    public void EndPowerup()
    {
        if (powerupCheck == true)
        {
            PlayerController.instance.DecreaseSpeed();
        }
    }

}
