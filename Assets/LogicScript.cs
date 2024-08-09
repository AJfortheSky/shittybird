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
    

    private void Start()
    {
        
    }

    public void addScore()
    {
        ui.UpdateScore(1);
        Debug.Log("score updated");
    }
}
