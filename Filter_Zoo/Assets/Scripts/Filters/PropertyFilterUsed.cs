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

    // Start is called before the first frame update
    void Start()
    {
        List<Singleton.Property> appliedFilter = Singleton.Instance.AppliedPropertyFilters;

        string startFilters = "Property filters applied: ";


        toCombine = "non";
        toCombine = startFilters + toCombine;
        textToChange.SetText(toCombine);
        Debug.Log(appliedFilter.Count);
    }

    // Update is called once per frame
    void Update()
    {
        List<Singleton.Property> appliedFilter = Singleton.Instance.AppliedPropertyFilters;
        string startFilters = "Property filters applied: ";
        toCombine = "";

        for (int i = 0; i < appliedFilter.Count; i = i + 2)
        {
            newFilter = appliedFilter[i].ToString();
            toCombine = toCombine + " / " + newFilter;
            wholeCombine = startFilters + toCombine;
            textToChange.SetText(wholeCombine);
        }

    }
}
