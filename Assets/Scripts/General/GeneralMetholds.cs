using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class GeneralMetholds : MonoBehaviour
{
    public static GeneralMetholds instance;

    private void Awake()
    {
        instance= this;
    }

    public void WaitToDo(Action action,float delay)
    {
        StartCoroutine(WaitToDoIE(action,delay));
    }
    private IEnumerator WaitToDoIE(Action action,float delay)
    {
        yield return new WaitForSeconds(delay);
        action();
    }
    /// <summary>
    /// Do action after ConditionAction return true
    /// </summary>
    /// <param name="action"></param>
    /// <param name="ConditionAction"></param>
    public void WaitActionToDo(Action action, Func<bool> ConditionAction)
    {
        StartCoroutine(WaitActionToDoIE(action, ConditionAction));
    }
    private IEnumerator WaitActionToDoIE(Action action, Func<bool> ConditionAction)
    {
        while (true)
        {
            yield return new WaitForEndOfFrame();

            if (ConditionAction())
            {
                action();
                break;
            }
        }
       
    }


}
