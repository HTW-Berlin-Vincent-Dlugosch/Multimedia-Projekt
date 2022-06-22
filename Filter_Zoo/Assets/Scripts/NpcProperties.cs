using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;



public class NpcProperties : MonoBehaviour
{
  public Singleton.Color Color = Singleton.Color.Blue;
  public Singleton.Size Size = Singleton.Size.Medium;
  public Singleton.Property Property_1 = Singleton.Property.Nothing;
  public Singleton.Property Property_2 = Singleton.Property.Nothing;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (Singleton.Instance.AppliedColorFilters.Contains(Color) ||
        Singleton.Instance.AppliedSizeFilters.Contains(Size) ||
        Singleton.Instance.AppliedPropertyFilters.Contains(Property_1) ||
        Singleton.Instance.AppliedPropertyFilters.Contains(Property_2))
    {
      Destroy(gameObject);
    }
  }
}
