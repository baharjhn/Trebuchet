using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Spacebar_E3 : MonoBehaviour
{
    public UnityEvent click;
    public GameObject clock;
    public AudioClip sound;
    int counter = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            counter++;
            Debug.Log("pressed");
            GameObject newClock = Instantiate(clock, new Vector3(clock.transform.position.x + counter*6, clock.transform.position.y, 0), clock.transform.rotation);
            playSound();
            
        }
         
    }
    void playSound()
    {
        if (sound != null)
        {
            GetComponent<AudioSource>().PlayOneShot(sound);
        }
    }
}
