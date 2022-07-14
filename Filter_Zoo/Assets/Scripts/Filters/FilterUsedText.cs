using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColorFilterUsedText : MonoBehaviour
{

  public TMP_Text textToChange;
  private string wholeCombine;
  private string toCombine;
  private string newFilter;

  // Update is called once per frame
  void Update()
  {
    List<Singleton.Color> appliedFilter = Singleton.Instance.AppliedColorFilters;
    textToChange.SetText("Color filters applied: " + string.Join(", ", appliedFilter));
  }
}