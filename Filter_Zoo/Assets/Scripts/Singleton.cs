using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
  public static Singleton Instance { get; private set; }

  public enum Color
  {
    Blue, White, Black, Red, Green, Orange, Pink, Grey, Brown
  }

  public enum Size
  {
    Small, Medium, Large
  }

  public enum Property
  {
    Hat, Weapon, Nothing
  }

  public List<GameObject> npcs;


  public List<Color> AppliedColorFilters = new List<Color>();

  public List<Size> AppliedSizeFilters = new List<Size>();

  public List<Property> AppliedPropertyFilters = new List<Property>();

  public GameObject npcToFind;

  private void Awake()
  {
    if (Instance == null)
    {
      npcToFind = npcs[Random.Range(0, npcs.Count)];
      npcs.Remove(npcToFind);
      Instance = this;
    }
    else
    {
      Destroy(gameObject);
    }
  }
}
