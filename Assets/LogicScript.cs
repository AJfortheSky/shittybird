using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;


public class LogicScript : MonoBehaviour
{
    [SerializeField] public UImanager ui;
    public pipemove pipeSpeed;


    private void Start()
    {
        
    }

    public void addScore()
    {
        ui.UpdateScore(1);
        //pipeSpeed.increaseSpeed();
        Debug.Log("score updated");
    }
}
