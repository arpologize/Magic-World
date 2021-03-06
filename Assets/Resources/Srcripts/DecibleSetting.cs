﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecibleSetting : MonoBehaviour
{
    [Range(-160, 160)]
    public float decibleBase;//=-30;
    [Range(0, 320)]
    public float threshold;//=30;
    [Space]
    public ProcessBar decibleBar;
 
    float current;
    DecibelMeter meter;
    // Start is called before the first frame update
    void Start()
    {
        meter = DecibelMeter.Instance;
    
    }

    public void AdjustDecibleBase(float newDecibleBase)
    {
        //Debug.Log(newDecibleBase);
        decibleBase = newDecibleBase;
    }

    // Update is called once per frame
    void Update()
    {
        current = meter.DbValue - decibleBase;
       if(decibleBar != null) decibleBar.updateGauge(threshold, current);
        //Debug.Log(threshold+"|" +(current - decibleBase));
    }
}
