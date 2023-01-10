using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Usa15 : MonoBehaviour
{
    List<InputDevice> devices;
    public XRNode controllerNode;
    public Animator door;
    int nr = 0;

    // Start is called before the first frame update
    void Start()
    {
        door = GetComponent<Animator>();
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

                if (device.TryGetFeatureValue(CommonUsages.primaryButton, out inputValue) && inputValue)
                {
                    if (nr == 0)
                    {
                        nr = 1;
                        door.Play("Usa15");
                    }
                    else
                    {
                        nr = 0;
                        door.Play("Usa15_Inchidere");
                    }
                }

            }

        }
    }
}
