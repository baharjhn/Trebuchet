using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class TimeSource_E5 : MonoBehaviour
{
    
    public GameObject minHand;
    public GameObject hourHand;
    public float customHour, customMin;
    public string choose;

    void Update()
    {
        switch (choose){
            case "now":
                UpdateClockRealTime();
                break;
            case "elapsed":
                UpdateClockSinceStartUp();
                break;
            case "custom":
                UpdateCustom();
                break;
            //default:
            //    UpdateClockRealTime();
            //    break;
        }

    }
    void UpdateClockRealTime()
    {
        DateTime currentTime = DateTime.Now;

        float minDegree = -(currentTime.Minute / 60f) * 360f;
        minHand.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, minDegree));

        float hourDegree = -(currentTime.Hour / 12f) * 360f;
        //Debug.Log(hourDegree);
        hourHand.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, hourDegree));
    }

    void UpdateClockSinceStartUp()
    {
        float startTime = Time.realtimeSinceStartup;

        float minutes = Mathf.Floor(startTime / 60f) % 60;
        float hours = Mathf.Floor(startTime / 3600f) % 12;

        float minDegree = -(minutes / 60f) * 360f;
        minHand.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, minDegree));

        float hourDegree = -(hours / 12f) * 360f;
        hourHand.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, hourDegree));
    }

    void UpdateCustom()
    {
        //float inHour = float.Parse(customHour.text);
        //float inMinute = float.Parse(customMin.text);
      
        float minDegree = -(customMin / 60f) * 360f;
        minHand.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, minDegree));

        float hourDegree = -(customHour / 12f) * 360f;
        hourHand.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, hourDegree));
    }

}
