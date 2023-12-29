using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPref : MonoBehaviour
{
    [System.Serializable]
    public class SavePlayerData
    {
        public string playerName;
        public float playerDate;
        public float affectionMeter;
        public float harmonyMeter;
    }

    private void Awake()
    {
        SavePlayerData savedPlayer = new SavePlayerData()
        {
            playerName = "",
            playerDate = 11,
            affectionMeter = 0,
            harmonyMeter = 0
        };

        PlayerPrefs.SetString("SavedPlayer", JsonUtility.ToJson(savedPlayer));
        PlayerPrefs.Save();
    }

    void Start()
    {
        var playerData = JsonUtility.FromJson<SavePlayerData>(PlayerPrefs.GetString("SavedPlayer"));
        Debug.Log(playerData.playerName);
        Debug.Log(playerData.playerDate);
        Debug.Log(playerData.affectionMeter);
        Debug.Log(playerData.harmonyMeter);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
