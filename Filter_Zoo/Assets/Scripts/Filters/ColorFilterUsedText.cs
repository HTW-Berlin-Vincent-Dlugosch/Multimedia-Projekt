using System.Collections.Generic;
using TMPro;
using UnityEngine;
/// <summary>
/// Script <c>ColorFilterUsedText</c> responsible for displaying text idicating which color filters are in use
/// </summary>
public class ColorFilterUsedText : MonoBehaviour
{
    /// <summary>
    /// Text that is displayed. Containing the list of applied filters
    /// </summary>
    public TMP_Text textToChange;
    void Update()
    {
        List<Singleton.Color> appliedFilter = Singleton.Instance.AppliedColorFilters;
        textToChange.SetText("Color filters applied: " + string.Join(", ", appliedFilter));
    }
}