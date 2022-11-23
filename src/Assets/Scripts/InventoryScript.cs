using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{

    public GameObject toolSpawn1;
    public GameObject toolSpawn2;
    public GameObject toolSpawn3;
    //public List<GameObject> toolSpawnList = new List<GameObject>() { toolSpawn1, toolSpawn2, toolSpawn3 };
    //public List<Transform> toolSpawnTransformList = new List<Transform>() { toolSpawn1.transform, toolSpawn2.transform, toolSpawn3.transform };

    public DirectorScript Director;
    public List<ToolScript> Tools = new List<ToolScript>();
    //public List<GameObject> ToolGameObjects = new List<GameObject>();
    public int id = 0;

    public GameObject syringe;
    public GameObject medicineVial;
    public GameObject gloveBox;

    /// <summary>
    /// Spawns Tools in the Scene;
    /// manages the User's Tool inventory.
    /// </summary>
    public InventoryScript() { }


    /// <summary>
    /// Create an inventory of three Tools "gloveBox", "syringe", and "medicineVial" with unique ID values and spawn locations.
    /// TODO: Implement prefabs to spawn Tools at runtime.
    /// </summary>
    public void PrepareTools()
    {
        Instantiate(syringe, toolSpawn1.transform);
        Instantiate(medicineVial, toolSpawn2.transform);
        Instantiate(gloveBox, toolSpawn3.transform);
        //Tools.Add(new ToolScript(GetNextId(), false, new Vector3((float)-6.817, (float)3.608, (float)0.7), "gloveBox"));
        //Tools.Add(new ToolScript(GetNextId(), false, Director.GetRandomToolSpawnPosition(), "syringe"));
        //Tools.Add(new ToolScript(GetNextId(), false, Director.GetRandomToolSpawnPosition(), "medicineVial"));
    }
    
    /// <summary>
    /// 
    /// </summary>
    public void MakeTool()
    {
        
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
        Debug.Log("debug: SpawnTools() fired");
        //List<string> someToolNames = new List<string>() { "syringe", "medicineVial", "gloveBox", "glove" };
        List<string> someToolNames = new List<string>() { "syringe", "medicineVial", "gloveBox" };

        for (int i = 0; i < Tools.Count; i++)
        {
            Debug.Log("The Tools available are:");
            Debug.Log(Tools[i].ToolName);
        }

        Debug.Log("\nSpawning the Tools:");
        while (Tools.Count > 0)
        {
            int i = Director.r.Next(0, Tools.Count-1);
            Debug.Log(" Tools Count is " + Tools.Count);
            Debug.Log(" and this Tool is : " + Tools[i].ToolName);

            Tools.RemoveAt(i);
        }

        Debug.Log("SpawnTools() complete and Inventory.Tools.Count is now " + Tools.Count);
    }

}
