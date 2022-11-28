using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicineVialScript : MonoBehaviour
{
    public GameObject InventoryManager;

    public bool hasMedicine = true;


    void Start()
    {
        InventoryManager = GameObject.FindGameObjectWithTag("IM");
        //Debug.Log(InventoryManager);
    }

    private void OnMouseDown()
    {
        Debug.Log("Clicked MedicineVial");
    }

    public void InteractWithSyringe()
    {
        // TODO
    }

    //public void PrintVialMedicine()
    //{
    //    if (hasMedicine)
    //    {
    //        Debug.Log("Vial has medicine");
    //    } else {
    //        Debug.Log("Vial does not have medicine");
    //    }
    //}

    public void MedicineVialAnnounce()
    {
        Debug.Log("I am a medicine vial being collided with by a syringe.");
    }

    public void MedicineTransfer()
    {
        hasMedicine = false;
        GetComponent<Renderer>().material.color = Color.grey;
    }
}
