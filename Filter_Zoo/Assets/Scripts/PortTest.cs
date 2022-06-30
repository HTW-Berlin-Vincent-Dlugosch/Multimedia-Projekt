using System.IO.Ports;
using UnityEngine;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

public class PortTest : MonoBehaviour
{
  // Start is called before the first frame update
  SerialPort serialPort;
  Thread readSerialPortThread;
  public Light mainLight;
  double brightness = 0;
  // public Light mainLight;
  void Start()
  {
    serialPort = new SerialPort(portName: "COM3", baudRate: 9600);
    serialPort.Open();
    serialPort.ReadTimeout = 50;
    readSerialPortThread = new Thread(ReadSerialPort);
    readSerialPortThread.Start();
  }

  void ReadSerialPort()
  {
    Queue<int> queue = new Queue<int>();

    while (true)
    {
      try
      {
        string line = serialPort.ReadLine();
        var measuredBrightness = int.Parse(line);
        queue.Enqueue(measuredBrightness);
        if (queue.Count > 50)
        {
          queue.Dequeue();
        }
        brightness = queue.Average() / 1000f;
      }
      catch (System.TimeoutException)
      {
      }
    }
  }
  // Update is called once per frame
  void Update()
  {
    mainLight.intensity = (float)brightness;

  }

  void OnDestroy()
  {
    readSerialPortThread.Abort();
    serialPort.Close();
  }
}
