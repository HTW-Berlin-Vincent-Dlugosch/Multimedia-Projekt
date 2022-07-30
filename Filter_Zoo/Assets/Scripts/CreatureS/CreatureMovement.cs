using UnityEngine;
/// <summary>
/// Script <c>CreatureMovement</c> is responsible for the movement of the NPCs
/// </summary>
public class CreatureMovement : MonoBehaviour
{
    /// <summary>
    /// Speed of NPCs
    /// </summary>
    public int speed;
    /// <summary>
    /// Waypoints Npcs walk between
    /// </summary>
    private Transform[] waypoints;
    /// <summary>
    /// Old Waypoints Npcs walk between
    /// </summary>
    private GameObject[] waypointsBefore;
    /// <summary>
    /// Index of the current waypoint
    /// </summary>
    private int waypointIndex;
    /// <summary>
    /// Distance between waypoint and npc
    /// </summary>
    private float distance;

    void Start()
    {
        var pos = this.transform.position;

        if (pos.x == 0 && pos.y == 100 &&
        pos.z == 0)
        {
            return;
        }

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
    /// <summary>
    /// Method <c>GoTo</c> Responsible for movement towards Waypoint
    /// </summary>
    void GoTo()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.forward);
    }

    void NewRandomIndex()
    {
        waypointIndex = Random.Range(0, waypoints.Length);
        transform.LookAt(waypoints[waypointIndex].position);
    }
}
