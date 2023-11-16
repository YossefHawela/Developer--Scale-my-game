using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProgress : MonoBehaviour
{

    public Action<float> ActionWhenProgressChanged;

    public Action ActionWhenProgressReach100;

    private float progress;
    public float Progress 
    {
        get 
        {
            return progress; 
        } 

        set
        {
            if (progress != Mathf.Clamp(value, 0, 100))
            {
                progress = value;
                progress = Mathf.Clamp(progress, 0, 100);

                if (ActionWhenProgressChanged != null)
                    ActionWhenProgressChanged(progress);

                if (ActionWhenProgressReach100 != null)
                    if(progress == 100)
                        ActionWhenProgressReach100();
            }
        }
    }

}
