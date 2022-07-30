using UnityEngine;
/// <summary>
/// Script <c>PlayerBehaviour</c> is responsible to detect the collision with the NPC to find. Moves NPC on platform and stops movement of said npc.
/// </summary>
public class PlayerBehaviour : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("NPCTOFIND"))
        {
            Debug.Log("GEFUNDEN!");
            collision.gameObject.GetComponent<CreatureMovement>().speed = 0;
            collision.gameObject.transform.position = new Vector3(0, 41f, 0);
        }
    }
}


