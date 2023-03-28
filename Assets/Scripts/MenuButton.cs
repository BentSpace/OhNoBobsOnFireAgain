using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    // inspired by https://www.youtube.com/watch?v=gSfdCke3684
    // Start is called before the first frame update

    [SerializeField] private string MainMenu = "MainMenu";

    // Update is called once per frame
    public void LoadMainMenu()
    {
        Destroy(GameObject.Find("Main Camera"));
        Destroy(GameObject.Find("SelectableEntities"));
        Destroy(GameObject.Find("Canvas"));
        Destroy(GameObject.Find("EntityMngr"));
        Destroy(GameObject.Find("ButtonManager"));
        // SceneManager.UnloadSceneAsync("DontDestroyOnLoad");
        SceneManager.LoadScene(MainMenu);
    }
}
