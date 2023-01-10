using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class OpenDoor11 : MonoBehaviour
{
    List<InputDevice> devices;
    public XRNode controllerNode;
    public Animator door;
    public GameObject door11;
    public Camera cam;

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
        Ray ray = cam.ScreenPointToRay(door.bodyPosition);
        RaycastHit hit;
        GetDevice();
        foreach (var device in devices)
        {
            Debug.Log(device.name + " " + device.characteristics);

            if (device.isValid)
            {
                bool inputValue;

                if (Physics.Raycast(ray,out hit) && device.TryGetFeatureValue(CommonUsages.gripButton, out inputValue) && inputValue)
                {
                    if (nr == 0)
                    {
                        nr = 1;
                        door.Play("Door11");
                        //hit.collider.gameObject.GetComponent<Animator>().Play("Door11");
                    }
                    else
                    {
                        nr = 0;
                        door.Play("Door11_Close");
                        //hit.collider.gameObject.GetComponent<Animator>().Play("Door11_Close");
                    }
                }

            }

        }
    }


}
