using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{
    public GameObject particleEffect;
    public GameObject fire;
    public GameObject winMessage;
    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
             particleEffect.SetActive(true);
             Destroy(fire);
             winMessage.SetActive(true);
        }
    }
}