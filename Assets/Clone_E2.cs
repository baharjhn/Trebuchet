using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone_E2 : MonoBehaviour
{
    public int numberOfClocks;
    public GameObject clock;
    // Start is called before the first frame update
    void Start()
    {
        createClock(numberOfClocks);
    }

    // Update is called once per frame
    void createClock(int num)
    {
        for (int i = 0; i < num; i++)
        {
            GameObject newClock = Instantiate(clock, new Vector3(i * 6 - 10, clock.transform.position.y, 0), clock.transform.rotation);
            newClock.name = "Clock No. " + (i + 1);
        }
    }
}
