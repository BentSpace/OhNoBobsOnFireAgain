using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EntityMngr : MonoBehaviour
{
    public List<GameObject> selectableEntities = new List<GameObject>();

    public GameObject[] selectablesArray;
    // Start is called before the first frame update
    void Start()
    {
        selectablesArray = GameObject.FindGameObjectsWithTag("SelectableEntities");
        foreach (var selectable in selectablesArray)
        {
            selectableEntities.Add(selectable);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resetEntityPositons()
    {
        foreach(GameObject entity in selectableEntities)
        {
            Rigidbody rb = entity.GetComponent<Rigidbody>();
            rb.isKinematic = true;
            // rb.detectCollisions = false;
            Vector3 last = entity.GetComponent<MoveObject>().lastPosition;
            entity.transform.position = last;
        }
    }

    public void saveEntityPositions()
    {
        foreach(GameObject entity in selectableEntities)
        {
            // Debug.Log("entity = " + entity, entity);
            Vector3 current = entity.transform.position;
            Vector3 last = entity.GetComponent<MoveObject>().lastPosition = current;
            // Debug.Log(last);
            // last = current;
            // Debug.Log(last);
        }
    }
}
