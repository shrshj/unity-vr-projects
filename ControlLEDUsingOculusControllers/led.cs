using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class led : MonoBehaviour
{
    // Start is called before the first frame update
    public SerialController serialController;
    void Start()
    {
        serialController = GameObject.Find("SerialController").GetComponent<SerialController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ledon()
    {
        serialController.SendSerialMessage("A");
    }

    public void ledoff()
    {
        serialController.SendSerialMessage("Z");
    }
}
