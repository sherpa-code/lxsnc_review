using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Spawns Tools in the Scene;
/// manages the User's Tool inventory.
/// </summary>
public class InventoryScript : MonoBehaviour
{

    public GameObject toolSpawn1;
    public GameObject toolSpawn2;
    public GameObject toolSpawn3;
    //public List<Transform> toolSpawnTransformList = new List<Transform>() { toolSpawn1.transform, toolSpawn2.transform, toolSpawn3.transform };

    public DirectorScript Director;
    //public List<ToolScript> Tools = new List<ToolScript>();
    public List<GameObject> Tools = new List<GameObject>();
    public List<GameObject> ToolsAll = new List<GameObject>();
    public int id = 0;

    public GameObject syringe;
    public GameObject medicineVial;
    public GameObject gloveBox;
    public GameObject glove;

    //public System.Random r = new System.Random();
    public Random r = new Random();

    public InventoryScript() {
        
    }



    /// <summary>
    /// Create an inventory of three Tools "gloveBox", "syringe", and "medicineVial" with unique ID values and spawn locations.
    /// </summary>
    public void PrepareTools()
    {
        //ToolsGO.Add(Instantiate(syringe, toolSpawn1.transform));
        Instantiate(syringe, toolSpawn1.transform);
        ToolsAll.Add(syringe);
        Instantiate(medicineVial, toolSpawn2.transform);
        ToolsAll.Add(medicineVial);
        Instantiate(gloveBox, toolSpawn3.transform);
        ToolsAll.Add(gloveBox);
    }
    
    /// <summary>
    /// 
    /// </summary>
    public void MakeTool()
    {
        
    }

    public void SpawnGlove()
    {
        Debug.Log("SpawnGlove() fired");
        //Instantiate(glove, toolSpawn3.transform);
        //Instantiate(glove, toolSpawn3.transform + new Transform());
        Instantiate(glove, toolSpawn3.transform);
    }

    /// <summary>
    /// Provide PrepareTools() with a unique ID value.
    /// </summary>
    /// <returns>unique int beginning at 0</returns>
    public int GetNextId()
    {
        return id++;
    }

    /// <summary>
    /// Instantiates Tools that exist at the start of a scene in a random order.
    /// </summary>
    public void SpawnTools()
    {
        //List<string> startingTools = new List<string>() { "syringe", "medicineVial", "gloveBox" };

        //for (int i = 0; i < Tools.Count; i++)
        //{
        //    Debug.Log("The Tools available are:");
        //    Debug.Log(Tools[i].ToolName);
        //}

        Debug.Log("\nSpawning starting Tools...");

        int i = 0;
        while (ToolsAll.Count > 0)
        {
            //i = r.Next(0, ToolsAll.Count - 1);
            i = Random.Range(0, ToolsAll.Count);
            Tools.Add(ToolsAll[i]);

            Debug.Log("Created the Tool " + ToolsAll[i].name);
            Debug.Log("There are now " + Tools.Count + " Tool(s).");

            ToolsAll.RemoveAt(i);
        }
    }

}