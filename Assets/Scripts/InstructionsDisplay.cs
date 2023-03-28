using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsDisplay : MonoBehaviour
{
    public GameObject instructions;
    public GameObject instructions2;

    public static bool newGame = true;
    // Start is called before the first frame update
    void Start()
    {
        // if (instructions != null) 
        if (newGame == true)
        {
            Debug.Log("Inside start");
            StartCoroutine(Display());
        }
    }

    IEnumerator Display()
    {
        yield return new WaitForSeconds(5f);
        // Destroy(instructions);
        Debug.Log("Inside Display");
        instructions.SetActive(false);
        instructions2.SetActive(true);
        yield return new WaitForSeconds(5f);
        instructions2.SetActive(false);
        // Destroy(instructions2);
        newGame = false;

    }
}
