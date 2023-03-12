using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Element_changer : MonoBehaviour
{
    private TMP_Dropdown dropdown;
    public GameObject gaugeBar;
    private void Start()
    {
        dropdown = GetComponent<TMP_Dropdown>();
    }
    public void Dropdown_ValueChanged()
    {
        Color element_color = Constants.Elements_Color[dropdown.value];
        gaugeBar.GetComponent<GaugeBar>().ElementChanged(element_color);
    }
}
