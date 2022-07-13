using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyFilter : MonoBehaviour
{
  public Singleton.Property Property;
  void Start()
  {
    gameObject.name = "PropertyFilter";
  }

  // Update is called once per frame
  void Update()
  {

  }
  void OnCollisionEnter(Collision collision)
  {

    if (collision.gameObject.tag == "Player")
    {
      Singleton.Instance.AppliedPropertyFilters.Add(Property);
      Destroy(gameObject);
    }
  }
}
