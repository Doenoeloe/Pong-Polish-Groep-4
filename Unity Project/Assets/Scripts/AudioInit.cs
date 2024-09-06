using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioInit : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GameObject ball = FindFirstObjectByType<BallMovement>().gameObject;
        ball.AddComponent<AudioManager>();
    }
}
