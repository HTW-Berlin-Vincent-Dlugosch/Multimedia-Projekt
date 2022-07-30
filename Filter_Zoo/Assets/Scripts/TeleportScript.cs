using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Script <c>TeleportScript</c> Responsible for teleportation
/// </summary>
public class TeleportScript : MonoBehaviour
{
  public float posX;
  public float posY;
  public float posZ;
  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("Player"))
    {
      other.gameObject.transform.position = new Vector3(posX, posY, posZ);
    }
  }
}
