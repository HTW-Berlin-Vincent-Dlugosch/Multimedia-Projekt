using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class PortTest : MonoBehaviour
{
    // Start is called before the first frame update
    SerialPort serialPort;

    void Start()
  {
        serialPort = new SerialPort("COM3", 9600);
        serialPort.Open();
        serialPort.ReadTimeout = 1;
    }

  // Update is called once per frame
  void Update()
  {
        if (serialPort.IsOpen)
        {
            try
            {
                Debug.Log(serialPort.ReadLine());
            }
            catch (System.Exception)
            {

            }
        }
  }
}
