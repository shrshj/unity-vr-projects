using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMsgListener : MonoBehaviour
{
    // Use this for initialization

    public string MyMSG;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Invoked when a line of data is received from the serial device.
    void OnMessageArrived(string msg)
    {
        Debug.Log("Arrived: " + msg);
        MyMSG = msg;

    }

    // Invoked when a connect/disconnect event occurs. The parameter 'success'
    // will be 'true' upon connection, and 'false' upon disconnection or
    // failure to connect.
    void OnConnectionEvent(bool success)
    {
        Debug.Log(success ? "Device connected" : "Device disconnected");
    }
}
