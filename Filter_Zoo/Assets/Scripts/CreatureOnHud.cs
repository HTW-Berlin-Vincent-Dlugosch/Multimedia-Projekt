using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureOnHud : MonoBehaviour
{
    private GameObject hudCreature;
    void Start()
    {
        hudCreature = Instantiate(Singleton.Instance.npcToFind, new Vector3(0f, 100f, 0f), Quaternion.identity);
        hudCreature.layer = 7;
        SetLayerRecursively(hudCreature, 7);


        
    }

    // Update is called once per frame
    void Update()
    {
        if(hudCreature == Singleton.Instance.npcToFind)
        {
            Destroy(hudCreature);
            hudCreature = Instantiate(Singleton.Instance.npcToFind, new Vector3(0f, 100f, 0f), Quaternion.identity);
            hudCreature.layer = 7;
            SetLayerRecursively(hudCreature, 7);
        }
        
    }

    void SetLayerRecursively(GameObject obj, int newLayer)
    {
        if (null == obj)
        {
            return;
        }

        obj.layer = newLayer;

        foreach (Transform child in obj.transform)
        {
            if (null == child)
            {
                continue;
            }
            SetLayerRecursively(child.gameObject, newLayer);
        }
    }



}
