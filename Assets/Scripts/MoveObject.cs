using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Collider))]
public class MoveObject : MonoBehaviour
{
    //code inspiration https://www.youtube.com/watch?v=bK5kYjpqco0 and https://answers.unity.com/questions/59355/change-the-material-on-an-object-in-a-script.html
    public Vector3 lastPosition;
    
    private Camera mainCamera;

    private float CameraZDistance;
    
    public Material Selected;
    public Material Selectable;

    //in the editor  is what you would set as the object you want to change
    public GameObject Object;
    
    // Start is called before the first frame update
    void Start()
    {
        mainCamera= Camera.main;
        CameraZDistance =
            mainCamera.WorldToScreenPoint(transform.position).z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDrag()
    {
        Vector3 ScreenPosition =
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, CameraZDistance);
        Vector3 NewWorldPosition =
            mainCamera.ScreenToWorldPoint(ScreenPosition);
        transform.position = NewWorldPosition;
    }

    void OnMouseOver()
    {
        Object.GetComponent<MeshRenderer> ().material = Selected;
    }

    private void OnMouseExit()
    {
        Object.GetComponent<MeshRenderer> ().material = Selectable;
    }
}
