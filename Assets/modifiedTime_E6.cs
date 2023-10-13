using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modifiedTime_E6 : MonoBehaviour
{
    public GameObject minuteHand;
    public GameObject hourHand;
    bool changed = true;
    // Update is called once per frame
    void Update()
    {
        
        DateTime currentTime = DateTime.Now;

        float minDegree = 10;//-(currentTime.Minute / 60f) * 360f;
        minuteHand.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, minDegree));
       
        float hourDegree = 10; //-(currentTime.Hour / 12f) * 360f;
        hourHand.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, hourDegree));
        
        if (minDegree == hourDegree || minDegree + 360 == hourDegree || minDegree - 360 == hourDegree && changed)
        {
            Debug.Log("Minute hand passed hour hand");
            changed = false;
        }
        else if (Mathf.Abs(minDegree - hourDegree) > 10f)
        {
            changed = true;
        }
    }
}
