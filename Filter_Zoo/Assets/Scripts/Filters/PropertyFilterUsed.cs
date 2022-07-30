using System.Collections.Generic;
using TMPro;
using UnityEngine;
/// <summary>
/// Script <c>PropertyFilterUsed</c> responsible for displaying text idicating which property filters are in use
/// </summary>
public class PropertyFilterUsed : MonoBehaviour
{
    /// <summary>
    /// Text that is displayed. Containing the list of applied filters
    /// </summary>
    public TMP_Text textToChange;
    void Update()
    {
        List<Singleton.Property> appliedFilter = Singleton.Instance.AppliedPropertyFilters;
        textToChange.SetText("Property filters applied: " + string.Join(", ", appliedFilter));
    }
}
