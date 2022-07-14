using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FilterUsedText : MonoBehaviour
{

  public TMP_Text textToChange;
  private string wholeCombine;
  private string toCombine;
  private string newFilter;

  // Start is called before the first frame update
  void Start()
  {
    List<Singleton.Color> appliedFilter = Singleton.Instance.AppliedColorFilters;
    string startFilters = "Color filters applied: ";
    toCombine = "non";
    toCombine = startFilters + toCombine;
    textToChange.SetText(toCombine);
  }

  // Update is called once per frame
  void Update()
  {
    List<Singleton.Color> appliedFilter = Singleton.Instance.AppliedColorFilters;
    string startFilters = "Color filters applied: ";
    toCombine = "";
    textToChange.SetText(startFilters + string.Join(",", appliedFilter));
    // for (int i = 0; i < appliedFilter.Count; i = i + 2)
    // {
    //   newFilter = appliedFilter[i].ToString();
    //   toCombine = toCombine + " / " + newFilter;
    //   wholeCombine = startFilters + toCombine;
    //   textToChange.SetText(wholeCombine);
    // }

  }
}
