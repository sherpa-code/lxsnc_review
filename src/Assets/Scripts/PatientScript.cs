using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An Interactable object in the scenario.
/// </summary>
public class PatientScript : MonoBehaviour
{
    public string PatientName;
    public bool PatientIsIll;
    public GameObject InventoryManager;

    private void OnMouseDown()
    {
        //Debug.Log("C");
        if (PatientIsIll) {
            Debug.Log("Clicked Patient; the Patient is ill.");
        } else
        {
            Debug.Log("Clicked Patient; the Patient has been healed.");
        }
        
    }

    public PatientScript(string interactableName, Vector3 interactablePosition, Color interactableColor)
    {
        GetComponent<Renderer>().material.color = interactableColor;
    }
}