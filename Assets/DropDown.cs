using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Wife;
public class DropDown : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    private void Awake()
    {
        dropdown = GetComponentInChildren<TMP_Dropdown>();

        PopulateList(typeof(Wife.Sign));
    }

    public void PopulateList(Type a)
    {
        string[] enumSigns = Enum.GetNames(a);
        List<string> signs = new List<string>(enumSigns);

        dropdown.AddOptions(signs);
    }
}
