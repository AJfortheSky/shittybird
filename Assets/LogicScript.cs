using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;


public class LogicScript : MonoBehaviour
{
    [FormerlySerializedAs("_ui")] [SerializeField] UI ui;

    private void Start()
    {
        
    }

    public void addScore()
    {
        ui.UpdateScore(1);
        Debug.Log("Sir they hit the second tower");
    }
}
