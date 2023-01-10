using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.XR;

public class EnterCitadel : MonoBehaviour
{
    List<InputDevice> devices;
    public XRNode controllerNode;

    // Start is called before the first frame update
    void Start()
    {
       
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

                if (device.TryGetFeatureValue(CommonUsages.primaryButton, out inputValue) && inputValue) //butonul x
                {
                    PhotonNetwork.LoadLevel("CetateaExterioara");
                }

            }

        }
    }

    private void OnCollisionEnetr(Collision col)
    {
        if(col.gameObject.name== "Enter")
        {
            PhotonNetwork.LoadLevel("CetateaExterioara");
        }
    }
}
