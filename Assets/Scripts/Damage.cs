﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

    private int damageMultiplier = 0;
    private int times_died = 0;
	
	public void increaseDamageMul (int multiplier)
    {
        damageMultiplier += multiplier;
        if(damageMultiplier < 0)
        {
            damageMultiplier = 0;
        }
        Debug.Log("multiplier: " + damageMultiplier);

    }

    public int getDamageMul()
    {
        return damageMultiplier;
    }

    public void resetDamageMul()
    {
        damageMultiplier = 0;
    }

    public void increaseTimesDied()
    {
        times_died++;
    }

    public int getTimesDied()
    {
        return times_died;
    }
}
