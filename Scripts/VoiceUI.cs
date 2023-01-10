using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Voice.PUN;
using Photon.Pun;
using Photon.Voice.Unity;
using System;

public class VoiceUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI micStatus;

    private PhotonVoiceNetwork punVoiceNetwork;

    private void Awake()
    {
        this.punVoiceNetwork = PhotonVoiceNetwork.Instance;
    }

    private void OnEnable()
    {
        this.punVoiceNetwork.Client.StateChanged += this.VoiceClientStateChanged;
    }

    private void OnDisable()
    {
        this.punVoiceNetwork.Client.StateChanged -= this.VoiceClientStateChanged;
    }

    private void Update()
    {
        if (this.punVoiceNetwork == null)
        {
            this.punVoiceNetwork = PhotonVoiceNetwork.Instance;
        }
    }

    private void VoiceClientStateChanged(Photon.Realtime.ClientState fromState, Photon.Realtime.ClientState toState)
    {
        this.UpdateUiBasedOnVoiceState(toState);
    }

    private void UpdateUiBasedOnVoiceState(Photon.Realtime.ClientState voiceClientState)
    {
        this.micStatus.text = string.Format("PhotonVoice: {0}", voiceClientState);
        if (voiceClientState == Photon.Realtime.ClientState.Joined)
        {
            micStatus.gameObject.SetActive(false);
        }
    }
}
