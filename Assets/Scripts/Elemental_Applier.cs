using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elemental_Applier : MonoBehaviour
{
    public GameObject Gauge_Bar;
    public void Elemental_Apply(float GaugeUnit)
    {
        Gauge_Bar.GetComponent<GaugeBar>().ElementAttached(GaugeUnit);
    }
}
