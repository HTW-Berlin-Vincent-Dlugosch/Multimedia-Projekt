using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuToggleColor : MonoBehaviour
{
  // Start is called before the first frame update

  public Singleton.Color color;

  Toggle m_Toggle;

  void Awake()
  {


  }
  void Start()
  {
    m_Toggle = GetComponent<Toggle>();
    m_Toggle.onValueChanged.AddListener(delegate
    {
      ToggleValueChanged(m_Toggle);
    });

  }

  //Output the new state of the Toggle into Text
  void ToggleValueChanged(Toggle change)
  {
    if (change.isOn)
    {
      Singleton.Instance.AvailableColorFilters.Add(color);
      Debug.Log("Color filter added: " + color.ToString());
    }
    else
    {
      Singleton.Instance.AvailableColorFilters.Remove(color);
      Debug.Log("Color filter removed: " + color.ToString());
    }
  }
}
