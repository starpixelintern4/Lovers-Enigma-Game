using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FadeAfterXSeconds : MonoBehaviour
{

    public void OnEnable()
    {
        StartCoroutine(Fade());
    }

    IEnumerator Fade()
    {
        Color c = transform.GetComponent<TextMeshProUGUI>().color;
        for (float alpha = 1f; alpha >= -0.2f; alpha -= 0.002f)
        {
            c.a = alpha;
            transform.GetComponent<TextMeshProUGUI>().color = c;
            yield return null;
        }
    }
}
