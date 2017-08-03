using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void RunPlayerVsPlayer()
    {
        Controller.activeAI = false;
        SceneManager.LoadScene(1);
    }

    public void RunPlayerVsAI()
    {
        Controller.activeAI = true;
        SceneManager.LoadScene(1);
    }
}
