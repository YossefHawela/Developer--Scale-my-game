using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BigRoomProgressChecker : GameProgress
{
    [SerializeField]
    private TextMeshProUGUI ProgressTextMesh;

    [SerializeField]
    private Transform Player;

    private Vector3 LastPlayerPos;

    private void Awake()
    {
        LastPlayerPos = Player.position;

        ActionWhenProgressChanged = delegate
        {
            ProgressTextMesh.text = "Progress: " + Progress.ToString("#.##") + "%";
        };

        ActionWhenProgressReach100 = delegate
        {
            GameConstraints.Instance.IsGamePaused = true;

            GeneralMetholds.instance.WaitToDo(delegate
            {
                EthanBot.Instance.DoAction("Realy?BigRoom");
            }, 1);
        };
    }
    private void Update()
    {
        AddProgress();
    }

    private void AddProgress()
    {
        float dis = Mathf.Abs((Player.position - LastPlayerPos).magnitude);

        Progress += dis;

        LastPlayerPos = Player.position;


    }
}
