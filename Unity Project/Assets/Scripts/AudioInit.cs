using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioInit : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // Finds  b a l l
        GameObject ball = FindFirstObjectByType<BallMovement>().gameObject;

        // Checks if ball is found
        if (ball == null)
        {
            Debug.Log("Failed to find ball");
            return;
        }

        // Adds the audio manager script to the ball
        ball.AddComponent<AudioManager>();
    }
}
