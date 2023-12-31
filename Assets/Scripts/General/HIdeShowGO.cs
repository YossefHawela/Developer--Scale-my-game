using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HIdeShowGO : MonoBehaviour
{

    [SerializeField]
    private GameObject Block;

    /// <summary>
    /// Show Black Screen
    /// </summary>
    public void Show()
    {
        Block.SetActive(true);
    }

    /// <summary>
    /// Show Black Screen After Delay in secs
    /// </summary>
    /// <param name="delay">delay value in secs</param>
    public void Show(float delay)
    {
        Invoke("Show", delay);
    }
    /// <summary>
    /// Hide Black Screen
    /// </summary>
    public void Hide()
    {
        Block.SetActive(false);
    }
    /// <summary>
    /// Hide BLack Screen after delay in secs
    /// </summary>
    /// <param name="delay">delay value in secs</param>
    public void Hide(float delay)
    {
        Invoke("Hide", delay);
    }
}
