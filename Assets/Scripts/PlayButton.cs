using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    // inspired by https://www.youtube.com/watch?v=gSfdCke3684
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField] private string Level1 = "Level1";

    // Update is called once per frame
    public void PlayButtonLoad()
    {
        SceneManager.LoadScene(Level1);
    }
}
