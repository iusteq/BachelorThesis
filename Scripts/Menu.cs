using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.Events;

public class Menu : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject Actions;
    public GameObject InfoPanel;
    public GameObject Map;
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
        Map.SetActive(false);
        InfoPanel.SetActive(false);
        Actions.SetActive(false);
        MenuPanel.SetActive(false);
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

                if (device.TryGetFeatureValue(CommonUsages.secondaryButton, out inputValue) && inputValue) //butonul y
                {
                    if (count == 0)
                    {
                        count = 1;
                        //Map.SetActive(true);
                        Actions.SetActive(true);
                        MenuPanel.SetActive(true);
                    }
                    else
                    {
                        count = 0;
                        //Map.SetActive(false);
                        Actions.SetActive(false);
                        MenuPanel.SetActive(false);
                    }
                }

            }

        }
    }
}
