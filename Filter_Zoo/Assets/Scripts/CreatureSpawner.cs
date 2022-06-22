using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureSpawner : MonoBehaviour
{
    public GameObject[] creatures;
    public int numberOfSpawns;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfSpawns; i++)
        {
            int arrayIndex = Random.Range(0, creatures.Length);
            Vector3 SpawnPosition = new Vector3(Random.Range(-15f, 45f), 1.5f, Random.Range(25f, 45f));

            Instantiate(creatures[arrayIndex], SpawnPosition, Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
