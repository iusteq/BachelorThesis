using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using TMPro;

public class ConnectButton : MonoBehaviour
{
    public Animator bridge;
    public Animator bridgeSupport;
    public Animator bridgeSupport2;
    public bool triggerPod;
    public Button connect;
    public GameObject ConnectPanel;

    // Start is called before the first frame update
    void Start()
    {
        bridge = GetComponent<Animator>();
        bridgeSupport = GetComponent<Animator>();
        bridgeSupport2 = GetComponent<Animator>();
        connect = GetComponent<Button>();
        connect.onClick.RemoveAllListeners();
        connect.onClick.AddListener(StartAnim);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartAnim()
    {
        StartCoroutine(BridgeCoroutine());
    }

    IEnumerator BridgeCoroutine()
    {
        bridge.SetBool("GetBridgeDown", true);
        bridgeSupport.SetBool("BS1", true);
        bridgeSupport2.SetBool("BS2", true);

        yield return new WaitForSecondsRealtime(0.5f);

        ConnectPanel.SetActive(false);
}
}
