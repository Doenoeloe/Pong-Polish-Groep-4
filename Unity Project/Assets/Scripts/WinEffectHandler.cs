using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinEffectHandler : MonoBehaviour
{
    GameObject ball;
    void Start()
    {
        ball = FindFirstObjectByType<BallMovement>().gameObject;
        ball.AddComponent<WinEffect>();
    }
}
