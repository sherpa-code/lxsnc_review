﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An Interactable the User may 'hold' and apply to other Interactables.
/// </summary>
public class ToolScript : InteractableScript
{
    public int ToolId { get; set; }
    public string ToolName { get; set; }
    public Vector3 ToolPosition { get; set; }
    public bool ToolContainsMedicine { get; set; }
    public GameObject ToolPrimitive { get; set; }
    public Color ToolColor { get; set; }
    public List<Vector3> somePositions = new List<Vector3>()
    {
        new Vector3(0, 0, 0),
        new Vector3(1, 1, 1),
        new Vector3(2, 2, 2),
        new Vector3(3, 3, 3)
    };


    public ToolScript(int toolId, bool toolContainsMedicine, Vector3 toolPosition, string toolType)
    //public ToolScript(int toolId, string interactableName, bool toolContainsMedicine, Vector3 toolPosition, Color interactableColor, string toolPrimitiveType) : base(interactableName, interactableColor)
    //public ToolScript(int toolId, string toolName, bool toolContainsMedicine, Vector3 interactablePosition, Color interactableColor, string toolPrimitiveType ) : base(interactablePosition, interactableColor)
    //public ToolScript(int toolId, string toolName, bool toolContainsMedicine, Vector3 interactablePosition, Color toolColor, string toolPrimitiveType ) : base(interactablePosition)
    {

        ToolId = toolId;
        ToolContainsMedicine = toolContainsMedicine;

        ToolPosition = toolPosition;
        //ToolColor = toolColor;
        //ToolColor = interactableColor;

        // Instantiate the Tools
        switch (toolType)
        {
            case "cube":
                ToolName = "Cube";
                ToolPrimitive = GameObject.CreatePrimitive(PrimitiveType.Cube);
                ToolColor = Color.blue;
                break;
            case "glove":
                ToolName = "Glove";
                ToolPrimitive = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                ToolColor = Color.cyan;
                //SetSpawnPosition(somePositions[1]);
                break;
            case "syringe":
                ToolName = "Syringe";
                ToolPrimitive = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                ToolColor = Color.yellow;
                //SetSpawnPosition(somePositions[2]);
                break;
            case "medicineVial":
                ToolName = "Vial (with Medicine)";
                ToolPrimitive = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                ToolColor = Color.red;
                //SetSpawnPosition(somePositions[3]);
                break;
            default:
                throw new KeyNotFoundException();
        }

        this.transform.position = ToolPosition;
        //ToolPrimitive.transform.position = ToolPosition;
        GetComponent<Renderer>().material.color = ToolColor;
        //ToolPrimitive.GetComponent<Renderer>().material.color = ToolColor;


        //ToolPrimitive = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }
}