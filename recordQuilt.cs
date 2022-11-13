using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LookingGlass; // make sure you're using LookingGlass

public class recordQuilt : MonoBehaviour
{
    public HoloplayRecorder recorder; // referencing HoloPlay Recorder
    bool recording = false;
    bool pause = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //start recording with 1
        if (Input.GetKeyDown(KeyCode.Alpha1) && !recording)
        {
            recorder.StartRecord();
            recording = true;
            Debug.Log("recording");
        }

        //pause recording with 2
        if (Input.GetKeyDown(KeyCode.Alpha2) && recording)
        {
            recorder.PauseRecord();
            pause = true;
            Debug.Log("paused");
        }

        //resume from pause with 3
        if (Input.GetKeyDown(KeyCode.Alpha3) && recording && pause)
        {
            recorder.ResumeRecord();
            pause = false;
            recording = true;
            Debug.Log("resumed from pause");
        }

        //stop recording quilt 
        if (Input.GetKeyDown(KeyCode.Alpha4) && recording)
        {
            recorder.EndRecord();
            recording = false;
            pause = false;
            Debug.Log("stopped recording");
        }
    }

}