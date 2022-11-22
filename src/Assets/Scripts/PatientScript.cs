using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An Interactable object in the scenario.
/// </summary>
public class PatientScript : InteractableScript
{
    public string PatientName;
    public bool PatientIsIll;

    public PatientScript(string interactableName, Vector3 interactablePosition, Color interactableColor)
    {
        GetComponent<Renderer>().material.color = interactableColor;
    }
}
