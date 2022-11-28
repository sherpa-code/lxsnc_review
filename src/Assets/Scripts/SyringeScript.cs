using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyringeScript : MonoBehaviour
{
    public bool hasMedicine = false;

    public GameObject InventoryManager;
    public GameObject Director;

    void Start()
    {
        InventoryManager = GameObject.FindGameObjectWithTag("IM");
        Director = GameObject.FindGameObjectWithTag("Director");
        //Debug.Log(InventoryManager);
    }

    private void OnMouseDown()
    {
        Debug.Log("Clicked Syringe");
    }

    public void OnCollisionEnter(Collision c)
    {
        TryMedicineReceive(c);
        TryPatientMedicine(c);
    }

    public void TryPatientMedicine(Collision c)
    {
        if ((c.gameObject.tag == "Patient") && hasMedicine)
        {
            GameObject patient = GameObject.FindGameObjectWithTag("Patient");
            //patient.PatientIsIll = false;
            patient.GetComponent<PatientScript>().PatientIsIll = false;
            Debug.Log("The Patient feels well!");
            hasMedicine = false;
            GetComponent<Renderer>().material.color = Color.gray;
            GameObject director = GameObject.FindGameObjectWithTag("Director");
            director.GetComponent<DirectorScript>().ScenarioSuccess();
        }
    }

    public void TryMedicineReceive(Collision c)
    {   
        if (InventoryManager.GetComponent<InventoryScript>().glovesEquipped)
        {

            if (c.gameObject.tag == "MedicineVial")
            {

                MedicineReceive(c);
            } else if (c.gameObject.tag == "Patient")
            {
                if (!hasMedicine)
                {
                    Debug.Log("Oops, the syringe is empty!");
                }
            }
        } else
        {
            Debug.Log("Oops, you can't put medicine into the syringe without gloves on!");
        }
    }


    //public void TryMedicineReceive(Collision c)
    //{
    //    //if (InventoryManager.glovesEquipped)
    //    //if (InventoryManager.GlovesEquipped())
    //    //c.collider.GetComponent<InventoryScript>().MedicineTransfer();
    //    //if (c.collider.GetComponent<InventoryScript>().glovesEquipped)
    //    if (c.collider.GetComponent<InventoryScript>().GlovesEquipped())
    //    {
    //        if (c.gameObject.tag == "MedicineVial")
    //        {
    //            MedicineReceive(c);
    //        }
    //        else if (c.gameObject.tag == "Patient")
    //        {
    //            if (!hasMedicine)
    //            {
    //                Debug.Log("Oops, the syringe is empty!");
    //            }
    //        }
    //    }
    //    else
    //    {
    //        Debug.Log("Sorry, you need gloves to administer medicine to the Patient.");
    //    }
    //}


    public void MedicineReceive(Collision c)
    {
        if (!hasMedicine)
        {
            hasMedicine = true;
            GetComponent<Renderer>().material.color = Color.red;
            c.collider.GetComponent<MedicineVialScript>().MedicineTransfer();
            Debug.Log("Syringe collided with a vial containing medicine.");
        } else {
             Debug.Log("Syringe collided with an empty Medicine Vial.");
        }

        if (c.gameObject.tag == "Patient")
        {
            Debug.Log("Syringe collided with Patient.");
        }
    }
}
