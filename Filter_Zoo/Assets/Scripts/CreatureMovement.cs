using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureMovement : MonoBehaviour
{
    public int speed;

    private Transform[] waypoints;
    private GameObject[] waypointsBefore;
    private int waypointIndex;
    private float distance;

    // Start is called before the first frame update
    void Start()
    {

        waypointsBefore = GameObject.FindGameObjectsWithTag("Waypoints");
        waypoints = new Transform[waypointsBefore.Length];
        Transform switchWaypoint;
        for (int i = 0; i < waypointsBefore.Length; i++)
        {
            switchWaypoint = waypointsBefore[i].transform;
            waypoints[i] = switchWaypoint;
        }
        waypointIndex = Random.Range(0,waypoints.Length);
        transform.LookAt(waypoints[waypointIndex].position);
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, waypoints[waypointIndex].position);
        if(distance < 1f)
        {
            NewRandomIndex();
        }
        GoTo();
    }

    void GoTo()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void NewRandomIndex()
    {
        waypointIndex = Random.Range(0, waypoints.Length);
        transform.LookAt(waypoints[waypointIndex].position);
    }
}
