using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{

    public DirectorScript Director;
    public List<ToolScript> Tools = new List<ToolScript>();
    public List<GameObject> ToolGameObjects = new List<GameObject>();
    public int id = 0;

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

        Tools.Add(new ToolScript(GetNextId(), false, new Vector3((float)-6.817, (float)3.608, (float)0.7), "gloveBox"));
        Tools.Add(new ToolScript(GetNextId(), false, Director.GetRandomToolSpawnPosition(), "syringe"));
        Tools.Add(new ToolScript(GetNextId(), false, Director.GetRandomToolSpawnPosition(), "medicineVial"));
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

}
