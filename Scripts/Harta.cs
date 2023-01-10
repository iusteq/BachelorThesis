using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Harta : MonoBehaviour
{
    public GameObject HartaPanel;

    List<InputDevice> devices;
    public XRNode controllerNode;
    // public UnityEvent OnSelectEnter;
    //public UnityEvent OnSelectExit;

    int count = 0;

    private void Awake()
    {
        devices = new List<InputDevice>();
    }

    void GetDevice()
    {
        InputDevices.GetDevicesAtXRNode(controllerNode, devices);
    }

    // Start is called before the first frame update
    void Start()
    {
        HartaPanel.SetActive(false);
        GetDevice();
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

                if (device.TryGetFeatureValue(CommonUsages.secondaryButton, out inputValue) && inputValue) //butonul b
                {
                    if (count == 0)
                    {
                        count = 1;
                        HartaPanel.SetActive(true);
                    }
                    else
                    {
                        count = 0;
                        HartaPanel.SetActive(false);
                    }
                }

            }

        }
    }
}
