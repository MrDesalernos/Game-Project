using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopWatch : MonoBehaviour
{
    public float timeStart = 0.0f;
    public Text textBox;
    public Text startBtnText;

    public bool timerActive = false;
    bool TimerActiveWork = false;
    bool TimerWork = true;

    //public Text currentTimeText;

    // Start is called before the first frame update
    void Start()
    {
        textBox.text = timeStart.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive)
        {
            timeStart += Time.deltaTime;
            textBox.text = timeStart.ToString("F2");
            TimerActiveWork = true;
        }

        if (TimerWork == true)
        {
            timeStart = 0.0f;
            timerActive = false;
        }

        if (TimerActiveWork == true)
        {
            startBtnText.text =  "Click 2X to Restart";
        }
        //TimeSpan time = TimeSpan.FromSeconds(currentTime);
        //currentTimeText.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
    }

    public void timerButton()
    {
        timerActive = !timerActive;
        TimerWork = !TimerWork;
    }
}
