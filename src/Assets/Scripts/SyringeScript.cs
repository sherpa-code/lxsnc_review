using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyringeScript : MonoBehaviour
{
    public bool hasMedicine = false;

    public GameObject InventoryManager;

    void Start()
    {
        InventoryManager = GameObject.FindGameObjectWithTag("IM");
        //Debug.Log(InventoryManager);
    }

    private void OnMouseDown()
    {
        Debug.Log("Clicked Syringe");
    }

    public void interactWithVial()
    {

    }

    public void interactWithPatient()
    {

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
        if (c.gameObject.tag == "MedicineVial")
        {
            MedicineReceive(c);
        }
    }


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
