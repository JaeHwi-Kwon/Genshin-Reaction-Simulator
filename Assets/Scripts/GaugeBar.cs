using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class GaugeBar : MonoBehaviour
{
    private float duration = 0f;
    private Slider slider;
    private float fade_duration = 0f;
    private float apply_timer = 0f;
    private bool isApplied = false;
    public void Start()
    {
        slider = GetComponent<Slider>();
    }
    // FixedUpdate is called once per frame in 60fps circumstances
    public void FixedUpdate()
    {
        duration -= Time.deltaTime;
        slider.value -= fade_duration*Time.deltaTime;
        apply_timer += Time.deltaTime;

        if(duration <= 0f && isApplied)
        {
            Debug.Log("Time lasted " + apply_timer + " seconds.");
            isApplied = false;
        }
    }

    public void ElementAttached(float GaugeUnit)
    {
        apply_timer = 0;
        isApplied = true;
        duration = Formulae.Duratation(GaugeUnit);
        slider.value = GaugeUnit * Constants.AURA_TAX;
        fade_duration = slider.value / duration;
    }
}
