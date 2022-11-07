using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectorScript : MonoBehaviour
{
    public PatientScript patient;
    public GameObject toolBench;
    public UserScript user;
    private int numberOfTools = 3;
    public List<ToolScript> tools;

    // Flow begins here
    void Start()
    {
        Debug.Log("Hey Lxsnc folks!   =)");
        prepareScenario();
    }

    /// <summary>
    /// 
    /// </summary>
    private void prepareScenario()
    {
        prepareTools();
        spawnTools();
    }

    /// <summary>
    /// 
    /// </summary>
    private void prepareTools()
    {
        for (int i = 0; i < numberOfTools; i++)
        {
            tools.Add(new ToolScript(i, "Syringe", true)); // create a syringe
            tools.Add(new ToolScript(i, "Medicine Vial", false)); // create a vial of medicine
            tools.Add(new ToolScript(i, "Box of Gloves", false)); // create a box of gloves
            tools.Add(new ToolScript(i, "Glove", false)); // create a more than one individual glove
        }

        shuffleTools();
    }

    /// <summary>
    /// 
    /// </summary>
    private void shuffleTools()
    {
        var r = new System.Random();
        var shuffledTools = new List<ToolScript>();
        var listCount = tools.Count;
        for (int i = 0; i < listCount; i++)
        {
            var listElement = r.Next(0, tools.Count);
            shuffledTools.Add(tools[listElement]);
            tools.Remove(tools[listElement]);
        }

        tools = shuffledTools;
        //shuffleTools();

        foreach (var tool in tools)
        {
            //Debug.Log("This tool is: " + tool.name);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    private void spawnTools()
    {
        foreach (ToolScript tool in tools)
        {
            break;
        }
    }


}