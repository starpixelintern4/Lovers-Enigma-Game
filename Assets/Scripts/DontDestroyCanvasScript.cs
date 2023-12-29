using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyCanvasScript : MonoBehaviour
{
    public static DontDestroyCanvasScript instance;
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
