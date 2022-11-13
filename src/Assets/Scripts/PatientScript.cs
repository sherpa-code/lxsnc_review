using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An Interactable object in the scenario.
/// </summary>
public class PatientScript : InteractableScript
{
    public string PatientName = "Patient McPerson";
    public bool PatientIsIll = true;

    public PatientScript(string interactableName, Vector3 interactablePosition, Color interactableColor)
    //public PatientScript(string interactableName, Vector3 interactablePosition, Color interactableColor) : base(interactableName, interactableColor)
    //public PatientScript(string interactableName, Vector3 interactablePosition, Color interactableColor) : base(interactableName, interactablePosition, interactableColor)
    {
        GetComponent<Renderer>().material.color = interactableColor;
    }
}
