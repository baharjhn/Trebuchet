using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_E1 : MonoBehaviour
{
    public GameObject minuteHand;
    public GameObject hourHand;

    // Update is called once per frame
    void Update()
    {
        DateTime currentTime = DateTime.Now;

        float minDegree = -(currentTime.Minute / 60f) * 360f;
        minuteHand.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, minDegree));

        float hourDegree = -(currentTime.Hour / 12f) * 360f;
        //Debug.Log(hourDegree);
        hourHand.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, hourDegree));
    }
}
