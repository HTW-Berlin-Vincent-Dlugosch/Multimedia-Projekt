using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PropertyFilterUsed : MonoBehaviour
{
    public TMP_Text textToChange;
    private string wholeCombine;
    private string toCombine;
    private string newFilter;

    // Update is called once per frame
    void Update()
    {
        List<Singleton.Property> appliedFilter = Singleton.Instance.AppliedPropertyFilters;  
        textToChange.SetText("Property filters applied: " + string.Join(", ", appliedFilter));       
    }
}
