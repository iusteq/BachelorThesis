using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayerSetUp : MonoBehaviourPunCallbacks
{
    public GameObject LocalXRRig;
    public GameObject Avatar;
    public TextMeshProUGUI PlayersName;
    public PhotonView photonView;

    // Start is called before the first frame update
    void Start()
    {
        if (photonView.IsMine)
        {
            //LocalXRRig.SetActive(true);
            Avatar.AddComponent<AudioListener>();
        }
        //else
        //{
        //    LocalXRRig.SetActive(false);
        //}

        if (PlayersName != null)
        {
            PlayersName.text = photonView.Owner.NickName;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
