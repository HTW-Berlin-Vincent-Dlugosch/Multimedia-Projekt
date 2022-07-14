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



  public List<Color> AvailableColorFilters = new List<Color>();

  public List<Size> AvailableSizeFilters = new List<Size>();

  public List<Property> AvailablePropertyFilters = new List<Property>();


  public GameObject npcToFind;

  private void Awake()
  {
    if (Instance == null)
    {
      ResetSingleton();
    }
    else
    {
      Destroy(gameObject);
    }
  }

  public void ResetSingleton()
  {
    AvailableColorFilters = new List<Color>() { Color.Blue, Color.White, Color.Black, Color.Red, Color.Green, Color.Orange, Color.Pink, Color.Grey, Color.Brown };
    if (npcToFind)
    {
      npcs.Add(npcToFind);
    }
    npcToFind = npcs[Random.Range(0, npcs.Count)];
    npcs.Remove(npcToFind);
    AppliedColorFilters = new List<Color>();
    AppliedSizeFilters = new List<Size>();
    AppliedPropertyFilters = new List<Property>();
    Instance = this;
  }
}
