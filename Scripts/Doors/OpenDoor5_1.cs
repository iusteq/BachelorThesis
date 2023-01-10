using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class OpenDoor5_1 : MonoBehaviour
{
    List<InputDevice> devices;
    public XRNode controllerNode;
    public Animator door;
    public Animator doorb;
    int nr = 0;

    // Start is called before the first frame update
    void Start()
    {
        door = GetComponent<Animator>();
        doorb = GetComponent<Animator>();
    }

    private void Awake()
    {
        devices = new List<InputDevice>();
    }

    void GetDevice()
    {
        InputDevices.GetDevicesAtXRNode(controllerNode, devices);
    }

    // Update is called once per frame
    void Update()
    {
        GetDevice();
        foreach (var device in devices)
        {
            Debug.Log(device.name + " " + device.characteristics);

            if (device.isValid)
            {
                bool inputValue;

                if (device.TryGetFeatureValue(CommonUsages.gripButton, out inputValue) && inputValue)
                {
                    if (nr == 0)
                    {
                        nr = 1;
                        door.Play("Door5_1a");
                        doorb.Play("Door5_1b");
                    }
                    else
                    {
                        nr = 0;
                        door.Play("Door5_1a_Close");
                        doorb.Play("Door5_1b_Close");
                    }
                }

            }

        }
    }
}
