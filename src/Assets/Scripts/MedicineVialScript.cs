using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicineVialScript : MonoBehaviour
{
    public bool hasMedicine;

    public GameObject InventoryManager;

    void Start()
    {
        InventoryManager = GameObject.FindGameObjectWithTag("IM");
        Debug.Log(InventoryManager);
    }

    private void OnMouseDown()
    {
        Debug.Log("Clicked MedicineVial");
    }

    public void interactWithSyringe()
    {
        // TODO
    }
}
