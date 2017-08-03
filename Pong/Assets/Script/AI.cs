using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {

    public GameObject ball;
    private float speed = 0.1f;

    // Use this for initialization
    void Start()
    {
        if (ball == null)
            Debug.LogError("Ball is not found");
    }

    // Update is called once per frame
    void Update()
    {
        float y = transform.position.y;

        if (ball.transform.position.y > transform.position.y)
            y += speed;
        else
            y -= speed;

        transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }
}
