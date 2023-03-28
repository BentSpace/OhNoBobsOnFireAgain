using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//inspired by https://www.youtube.com/watch?v=TVSLCZWYL_E
public class ResetButton : MonoBehaviour
{
    public EntityMngr entityMngr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        entityMngr.GetComponent<EntityMngr>().resetEntityPositons();

    }
}
