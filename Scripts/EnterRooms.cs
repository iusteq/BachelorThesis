using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.XR;

public class EnterRooms : MonoBehaviour
{
    //public GameObject Camera11;
    //public GameObject Camera10;
   
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnterRoom15()
    {
        PhotonNetwork.LoadLevel("Camera15");
    }

    public void EnterRoom13()
    {
        PhotonNetwork.LoadLevel("Camera13");
    }

    public void EnterRoom12()
    {
        PhotonNetwork.LoadLevel("Camera12");
    }

    public void EnterRoom11()
    {
        PhotonNetwork.LoadLevel("Camerele11-12");
    }

    public void EnterRoom10()
    {
        PhotonNetwork.LoadLevel("Camera10");
    }

    public void EnterRoom9()
    {
        PhotonNetwork.LoadLevel("Camera9");
    }

    public void EnterRoom8()
    {
        PhotonNetwork.LoadLevel("Camera8");
    }

    public void EnterRoom7()
    {
        PhotonNetwork.LoadLevel("Camera7");
    }

    public void EnterRoom6()
    {
        PhotonNetwork.LoadLevel("Camera6");
    }

    public void EnterStairs15()
    {
        PhotonNetwork.LoadLevel("Scari15");
    }

    public void EnterRoom5()
    {
        PhotonNetwork.LoadLevel("Camera5");
    }

    public void EnterRoom4()
    {
        PhotonNetwork.LoadLevel("Camera4");
    }

    public void EnterRoom3()
    {
        PhotonNetwork.LoadLevel("Camera3");
    }

    public void EnterRoom2()
    {
        PhotonNetwork.LoadLevel("Camera2");
    }
}
