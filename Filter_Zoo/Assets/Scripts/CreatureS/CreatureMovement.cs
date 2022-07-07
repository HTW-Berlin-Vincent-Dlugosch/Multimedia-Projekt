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
    var pos = this.transform.position;

    if (pos.x > -16 && pos.x < 46 &&
   pos.z > 24 && pos.z < 46)
    {
      waypointsBefore = GameObject.FindGameObjectsWithTag("Waypoints");
      waypoints = new Transform[waypointsBefore.Length];
    }

    if (pos.x > -46 && pos.x < -26 &&
   pos.z > -28 && pos.z < 44)
    {
      waypointsBefore = GameObject.FindGameObjectsWithTag("Waypoints2");
      waypoints = new Transform[waypointsBefore.Length];
    }

    if (pos.x > -45 && pos.x < 85 &&
   pos.z > -46 && pos.z < -37)
    {
      waypointsBefore = GameObject.FindGameObjectsWithTag("Waypoints3");
      waypoints = new Transform[waypointsBefore.Length];
    }

    if (pos.x > -15 && pos.x < 45 &&
   pos.z > -26.5 && pos.z < 15.5)
    {
      waypointsBefore = GameObject.FindGameObjectsWithTag("Waypoints4");
      waypoints = new Transform[waypointsBefore.Length];
    }

    if (pos.x > 54 && pos.x < 84 &&
   pos.z > -26 && pos.z < 46)
    {
      waypointsBefore = GameObject.FindGameObjectsWithTag("Waypoints5");
      waypoints = new Transform[waypointsBefore.Length];
    }

    Transform switchWaypoint;
    if (waypointsBefore != null)
    {
      for (int i = 0; i < waypointsBefore.Length; i++)
      {
        switchWaypoint = waypointsBefore[i].transform;
        waypoints[i] = switchWaypoint;
      }
      waypointIndex = Random.Range(0, waypoints.Length);
      transform.LookAt(waypoints[waypointIndex].position);
    }
  }

  // Update is called once per frame
  void Update()
  {
    if (waypoints != null)
    {
      distance = Vector3.Distance(transform.position, waypoints[waypointIndex].position);
      if (distance < 1f)
      {
        NewRandomIndex();
      }
      GoTo();
    }


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
