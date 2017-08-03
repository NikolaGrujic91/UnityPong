using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;

public class Controller : MonoBehaviour {

    public static int player1Points;
    public static int player2Points;
    public static bool activeAI = false;
    public GameObject Ball;
    public GameObject AI;
    public GameObject Player2;
    public GameObject GameOverPanel;
    public GameObject ObstaclePack1;
    public GameObject ObstaclePack2;
    public GameObject ObstaclePack3;
    public GameObject ObstaclePack4;
    private List<GameObject> obstaclePacks;

    // Use this for initialization
    void Start () {
        player1Points = 0;
        player2Points = 0;
        Time.timeScale = 1;

        CheckIfAssigned(Ball);
        CheckIfAssigned(AI);
        CheckIfAssigned(Player2);
        CheckIfAssigned(GameOverPanel);
        CheckIfAssigned(ObstaclePack1);
        CheckIfAssigned(ObstaclePack2);
        CheckIfAssigned(ObstaclePack3);
        CheckIfAssigned(ObstaclePack4);

        obstaclePacks = new List<GameObject>();
        obstaclePacks.Add(ObstaclePack1);
        obstaclePacks.Add(ObstaclePack2);
        obstaclePacks.Add(ObstaclePack3);
        obstaclePacks.Add(ObstaclePack4);
        InvokeRepeating("ActivateObstaclePack", 2.0f, 10.0f);
        InvokeRepeating("BallSize", 2.0f, 10.0f);

        if (activeAI)
            AI.SetActive(true);
        else
            Player2.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
	    if (player1Points == 11 || player2Points == 11)
        {
            Time.timeScale = 0.0f;
            GameOverPanel.transform.GetChild(1).GetComponent<Text>().text = player1Points == 11 ? "Player 1 Won!" : "Player 2 Won!";
            GameOverPanel.SetActive(true);
        }
	}

    private void ActivateObstaclePack()
    {
        int index = Random.Range(0, 4);

        for(int i = 0; i < obstaclePacks.Count; i++)
                obstaclePacks[i].SetActive(i == index);
    }

    private void BallSize()
    {
        float randomScale = Random.Range(0.5f, 1.5f);
        Ball.transform.localScale = new Vector3(randomScale, randomScale, randomScale);
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void CheckIfAssigned(GameObject go)
    {
        if (go == null)
            Debug.LogError("Game object is not assigned");
    }

}
