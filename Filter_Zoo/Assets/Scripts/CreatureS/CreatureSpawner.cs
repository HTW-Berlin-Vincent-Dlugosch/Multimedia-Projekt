using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script <c>CreatureSpawner</c> Is responsible for the instatiation of the NPCs.
/// </summary>
public class CreatureSpawner : MonoBehaviour
{
    /// <summary>
    /// All possible NPCs that can spwan
    /// </summary>
    public List<GameObject> creatures;
    /// <summary>
    /// Number of NPCs to spawn
    /// </summary>
    public int numberOfSpawns;
    public float xleft;
    public float xright;
    public float zleft;
    public float zright;

    public bool hasCharacterToFind = false;

    void Start()
    {
        if (hasCharacterToFind)
        {
            creatures.Add(Singleton.Instance.npcToFind);
        }
        else
        {
            creatures = Singleton.Instance.npcs;
        }

        for (int i = 0; i < numberOfSpawns; i++)
        {
            int arrayIndex = Random.Range(0, creatures.Count);
            Vector3 SpawnPosition = new Vector3(Random.Range(xleft, xright), 1.5f, Random.Range(zleft, zright));
            var instance = Instantiate(creatures[arrayIndex], SpawnPosition, Quaternion.identity);
            if (hasCharacterToFind)
            {
                instance.tag = "NPCTOFIND";
            }

        }
    }
}
