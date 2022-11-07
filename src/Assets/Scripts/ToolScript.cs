using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolScript : InteractableScript
{
    public int toolId;
    public string toolName;
    public bool hasVialAttached = false;


    public ToolScript(int toolId, string toolName, bool hasVialAttached)
    {
        this.toolId = toolId;
        this.toolName = toolName;
        this.hasVialAttached = false;
    }


    //public ToolScript(int toolId, string toolName)
    //{
    //    this.toolId = toolId;
    //    this.toolName = toolName;
    //}
}
