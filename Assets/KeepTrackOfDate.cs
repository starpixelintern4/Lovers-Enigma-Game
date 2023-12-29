using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepTrackOfDate : MonoBehaviour
{
    public static KeepTrackOfDate instance;
    public int day;
    public int hour;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
