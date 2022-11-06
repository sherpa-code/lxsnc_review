using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectorScript : MonoBehaviour
{
    public List<ToolScript> tools;
    public PatientScript patient;
    public GameObject toolBench;

    void Start()
    {
        prepareTools();
        spawnTools();
    }

    private void prepareTools()
    {

    }

    private void spawnTools()
    {
        foreach (ToolScript tool in tools)
        {
            break;
        }
    }


}
