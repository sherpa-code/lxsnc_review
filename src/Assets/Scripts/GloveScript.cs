using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class GloveScript : MonoBehaviour
{
    public GameObject InventoryManager;

    void Start()
    {
        InventoryManager = GameObject.FindGameObjectWithTag("IM");
        Debug.Log(InventoryManager);
    }

    private void OnMouseDown()
    {
        Debug.Log("Clicked GloveBox");
    }


    public void interactWithHand()
    {
        // TODO
    }
}
