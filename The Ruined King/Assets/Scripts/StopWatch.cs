using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopWatch : MonoBehaviour
{
    bool stopwatchActive = false;
    float currentTime;
    //public Text currentTimeText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (stopwatchActive == true)
        {
            currentTime = currentTime - Time.deltaTime;
        }
        //TimeSpan time = TimeSpan.FromSeconds(currentTime);
        //currentTimeText.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
    }

    public void StartStopwatch()
    {
        stopwatchActive = true;
    }

    public void Stopwatch()
    {
        stopwatchActive = false;
    }
}
