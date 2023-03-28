using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonBehaviour : MonoBehaviour
{
    public Rigidbody rb;

    public GameObject sphere;

    public EntityMngr entityMngr;
    // Start is called before the first frame update
    void Start()
    {
        rb = sphere.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void OnButtonPress()
   {
       entityMngr.GetComponent<EntityMngr>().saveEntityPositions();
       rb.isKinematic = false;
       rb.detectCollisions = true;
       
   }
}
