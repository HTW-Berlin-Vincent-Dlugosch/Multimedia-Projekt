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
  

  public List<Color> AppliedColorFilters = new List<Color>();

  public List<Size> AppliedSizeFilters = new List<Size>();

  public List<Property> AppliedPropertyFilters = new List<Property>();

  private void Awake()
  {
    if (Instance == null)
    {
      Instance = this;
    }
    else
    {
      Destroy(gameObject);
    }
  }
}
