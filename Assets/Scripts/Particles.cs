using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{
    public GameObject particleEffect;
    public GameObject fire;
    public GameObject winMessage;

    // private void Start()
    // {
    //     if (fire == null)
    //     {
    //         fire = GameObject.Find("FireBall");
    //     }
    // }

    void OnCollisionEnter(Collision coll)
    {
        if (fire == null)
        {
            fire = GameObject.Find("FireBall");
        }
        if (coll.collider.CompareTag("Player"))
        {
             particleEffect.SetActive(true);
             Destroy(fire);
             winMessage.SetActive(true);
        }
    }
}