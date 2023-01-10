using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ExitRoomsManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExitRoom15()
    {
        PhotonNetwork.LoadLevel("IesireCamera15");
    }

    public void ExitRoom13()
    {
        PhotonNetwork.LoadLevel("IesireCamera13");
    }

    public void ExitRoom12()
    {
        PhotonNetwork.LoadLevel("IesireCamera12");
    }

    public void ExitRoom11()
    {
        PhotonNetwork.LoadLevel("IesireCamera11");
    }

    public void ExitRoom10()
    {
        PhotonNetwork.LoadLevel("IesireCamera10");
    }

    public void ExitRoom9()
    {
        PhotonNetwork.LoadLevel("IesireCamera9");
    }

    public void ExitRoom8()
    {
        PhotonNetwork.LoadLevel("IesireCamera8");
    }

    public void ExitRoom7()
    {
        PhotonNetwork.LoadLevel("IesireCamera7");
    }

    public void ExitRoom6()
    {
        PhotonNetwork.LoadLevel("IesireCamera6");
    }

    public void ExitStairs15()
    {
        PhotonNetwork.LoadLevel("Scari15");
    }

    public void ExitRoom5()
    {
        PhotonNetwork.LoadLevel("IesireCamera5_1");
    }

    public void ExitRoom4()
    {
        PhotonNetwork.LoadLevel("IesireCamera4");
    }

    public void ExitRoom3()
    {
        PhotonNetwork.LoadLevel("IesireCamera3");
    }

    public void ExitRoom2()
    {
        PhotonNetwork.LoadLevel("IesireCamera2");
    }
}
