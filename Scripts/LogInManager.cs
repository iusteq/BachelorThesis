using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;

public class LogInManager : MonoBehaviourPunCallbacks  
{
    public TMP_InputField playersName;
    //private Animator bridge;
    //private Animator bridgeSupport;
    //private Animator bridgeSupport2;
    public GameObject ConnectPanel;
    public GameObject ConnectingOptions;
    public GameObject LogInCanvas;

    #region Unity

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator EnterCitadelCouroutine()
    {
        yield return new WaitForSecondsRealtime(10f);
        PhotonNetwork.LoadLevel("CetateaExterioara");
    }


    #endregion

    #region Photon

    public override void OnConnected()
    {
        Debug.Log("OnConnected called! Server available!");
    }

    public override void OnConnectedToMaster()
    {
        //PhotonNetwork.LoadLevel("CetateaExterioara");
        //bridge.Play("BridgeDown");
        //bridgeSupport.Play("BridgeSupportDown");
        //bridgeSupport2.Play("BridgeSupportDown");
        //StartCoroutine(EnterCitadelCouroutine());

    }

    #endregion

    #region UI

    public void ConnectToPhotonServer()
    {
        if(!playersName)
        {
            PhotonNetwork.NickName = playersName.text;
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    public void OnConnectButton()
    {
        ConnectPanel.SetActive(false);
        ConnectingOptions.SetActive(false);
        LogInCanvas.SetActive(false);
        StartCoroutine(EnterCitadelCouroutine());
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    #endregion
}
