using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyManager : MonoBehaviour
{
    public static EnergyManager instance;
    public int energy;
    public int minEnergy;
    public int maxEnergy;

    private void Awake()
    {
        if(instance = null)
        instance = this;
    }

    public void CheckEnergy(int energyConsumeAmount)
    {
        if(energy < energyConsumeAmount)
        {
            //do some dialogue I guess
            return;
        }
        else
        {
            energy -= energyConsumeAmount;
            //perform action
            if(energy < minEnergy)
            {
                //go to next day
                KeepTrackOfDate.instance.day ++;
                energy = maxEnergy; //reset energy back to max for the next day
            }
        }
    }
}
