using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// Adapted from https://www.youtube.com/watch?v=HXaFLm3gQws

public class DontDestroy : MonoBehaviour
{
    // public string objectID;
    // private void Awake()
    // {
    //     // objectID = name + transform.position.ToString() + transform.eulerAngles.ToString();
    // }
    void Awake()
    {
        // GameObject[] objs = GameObject.Find(gameObject.name);
        var objs = Resources.FindObjectsOfTypeAll<GameObject>().Where(obj => obj.name == gameObject.name);

        if (objs.Count() > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        // for (int i = 0; i < Object.FindObjectsOfType<DontDestroy>().Length; i++)
        // {
        //     if (Object.FindObjectsOfType<DontDestroy>()[i] != this)
        //     {
        //         if (Object.FindObjectsOfType<DontDestroy>()[i].objectID == objectID)
        //         {
        //             Debug.Log("destroying " + gameObject, gameObject);
        //             Destroy(gameObject);
        //         }
        //     }
        // }
        // GameObject.Find(gameObject.name)
        // if (gameObject.name == )
        // DontDestroyOnLoad(gameObject); 
    }
}