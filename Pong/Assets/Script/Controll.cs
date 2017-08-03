using UnityEngine;
using System.Collections;

public class Controll : MonoBehaviour {

    private float speed = 0.2f;
    private float speedIncrease = 0.2f;

    private void Update()
    {
        if (Input.touchCount > 2)
            return;
        
        foreach (Touch touch in Input.touches)
        {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            Vector2 currentPosition = transform.position;
            
            if (Mathf.Abs(touchPos.x - currentPosition.x) <= 2)
            {
                currentPosition.y = Mathf.Lerp(currentPosition.y, touchPos.y, (speed + speedIncrease));
                currentPosition.y = Mathf.Clamp(currentPosition.y, -2, 4); 
                transform.position = currentPosition;
            }
        }
    }
}

