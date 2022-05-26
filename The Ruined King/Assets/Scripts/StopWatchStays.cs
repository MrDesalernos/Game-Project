using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class StopWatchStays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
