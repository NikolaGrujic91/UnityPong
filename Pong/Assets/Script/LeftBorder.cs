using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LeftBorder : MonoBehaviour {

    public GameObject Score;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Ball" || other.name == "Ball(Clone)")
        {
            Controller.player1Points++;
            Score.GetComponent<Text>().text = Controller.player1Points.ToString();

            if (Controller.player2Points < 11 && Controller.player1Points < 11)
                other.transform.position = new Vector3(0, 1, 0);
        }
    }
}
