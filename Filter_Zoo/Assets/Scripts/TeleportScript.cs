using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
  // Start is called before the first frame update
  public float posX;
  public float posY;
  public float posZ;
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.tag == "Player")
    {
      other.gameObject.transform.position = new Vector3(posX, posY, posZ);
    }
  }
}
