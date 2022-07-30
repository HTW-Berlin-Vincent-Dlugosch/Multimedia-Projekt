using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using UnityEngine;
/// <summary>
/// Script <c>AmbientLight</c> is responsible for the dimming and brightening of the game scene according to the values supplied by the arduino.
/// The arduino is providing brightness data from the real world.
/// </summary>
public class AmbientLight : MonoBehaviour
{
    /// <summary>
    /// Can be toggled to indicate the arduino is connected
    /// </summary>
    public bool isConnected = false;
    /// <summary>
    /// Serial Port on which the arduino sends
    /// </summary>
    SerialPort serialPort;
    /// <summary>
    /// Thread to run concurrently and listen to serial port. Needed because of thread blocking in update method
    /// </summary>
    Thread readSerialPortThread;
    /// <summary>
    /// Main Light that is made brighter or dimmer
    /// </summary>
    public Light mainLight;
    /// <summary>
    /// Brightness calculated by ReadSerialPort method
    /// </summary>
    double brightness = 1.0;
    void Start()
    {
        if (isConnected)
        {
            serialPort = new SerialPort(portName: "/dev/cu.usbmodem1401", baudRate: 9600);
            serialPort.Open();
            serialPort.ReadTimeout = 50;
            readSerialPortThread = new Thread(ReadSerialPort);
            readSerialPortThread.Start();
        }
    }
    /// <summary>
    /// Mathod <c>ReadSerialPort</c> reads serial port and calculates moving average to set the brightness of the attached light
    /// </summary>
    void ReadSerialPort()
    {
        Queue<int> queue = new();

        while (true)
        {
            try
            {
                string line = serialPort.ReadLine();
                var measuredBrightness = int.Parse(line);
                queue.Enqueue(measuredBrightness);
                if (queue.Count > 30)
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
    void Update()
    {
        mainLight.intensity = (float)brightness;
    }

    void OnDestroy()
    {
        if (isConnected)
        {
            readSerialPortThread.Abort();
            serialPort.Close();
        }
    }
}
