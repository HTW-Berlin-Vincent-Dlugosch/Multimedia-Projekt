using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FilterOnMapScript : MonoBehaviour
{

    public TMP_Text textToChange;
    void Start()
    {
        GameObject[] filterOnMap = GameObject.FindGameObjectsWithTag("PropertyFilters");
        for(int i = 0; i < filterOnMap.Length; i++)
        {
            GameObject filter = filterOnMap[i];
        }
    }
}
