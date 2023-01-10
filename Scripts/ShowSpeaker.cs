using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Voice.PUN;

public class ShowSpeaker : MonoBehaviour
{
    [SerializeField]
    private Image micImage;

    [SerializeField]
    private Image speakerImage;

    [SerializeField]
    private PhotonVoiceView photonVoiceView;

    private void Awake()
    {
        this.micImage.enabled = false;
        this.speakerImage.enabled = false;
    }

    void Update()
    {
        this.micImage.enabled = this.photonVoiceView.IsRecording;
        this.speakerImage.enabled = this.photonVoiceView.IsSpeaking;
    }
}
