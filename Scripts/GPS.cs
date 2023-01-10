using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPS : MonoBehaviour
{
    public Transform player;
    //public GameObject dot;
    //Vector3 prev;
    //Vector2 dotPos;
    //float speed;
    // Start is called before the first frame update
    //void Start()
    //{
    //    prev = cam.position;
    //    dotPos = dot.transform.position;
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if(prev.x != cam.position.x || prev.z !=cam.position.z)
    //    {
    //        dotPos.x += (cam.position.x - prev.x) * speed;
    //        dotPos.y += (cam.position.z - prev.z) * speed;
    //        dot.transform.position = new Vector2(dotPos.x, dotPos.y);
    //    }
    //}

    private void LateUpdate()
    {
        Vector3 newPoz = player.position;
        newPoz.y = transform.position.y;
        transform.position = newPoz;
    }
}
