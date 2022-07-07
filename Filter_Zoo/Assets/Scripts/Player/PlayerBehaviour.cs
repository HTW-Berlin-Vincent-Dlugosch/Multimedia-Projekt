using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnCollisionEnter(Collision collision)
  {

    if (collision.gameObject.name == "ColorFilter")
    {
      var color = collision.gameObject.GetComponent<ColorFilterScript>().Color;
      Singleton.Instance.AppliedColorFilters.Add(color);
      Debug.Log(collision.gameObject.name + color.ToString());

      Destroy(collision.gameObject);
    }
    
    if (collision.gameObject.name == "PropertyFilter")
    {
      var property = collision.gameObject.GetComponent<PropertyFilter>().Property;
      Singleton.Instance.AppliedPropertyFilters.Add(property);
      Destroy(collision.gameObject);
    }
  }
}
