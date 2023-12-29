using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public string sceneName;
    public bool randomBool;

    public void ChangeToScene()
    {
        if(randomBool)
        SceneManager.LoadScene(sceneName);
    }

    public void ChangeBool()
    {
        randomBool = !randomBool;
    }

    public void ChangeToPreviousScene()
    {
        PixelCrushers.SaveSystem.LoadScene(Level.PreviousLevel);
    }
}
