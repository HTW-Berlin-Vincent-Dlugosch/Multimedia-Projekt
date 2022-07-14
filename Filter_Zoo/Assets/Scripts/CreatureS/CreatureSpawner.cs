using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureSpawner : MonoBehaviour
{
  public List<GameObject> creatures;
  public int numberOfSpawns;
  public float xleft;
  public float xright;
  public float zleft;
  public float zright;

  public bool hasCharacterToFind = false;

  // Start is called before the first frame update
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

  // Update is called once per frame
  void Update()
  {

  }
}
