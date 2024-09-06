using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBallTrailToBall : MonoBehaviour
{
    GameObject ball;

    private void Start()
    {
        if (!FindFirstObjectByType<BallMovement>().gameObject) return;

        ball = FindFirstObjectByType<BallMovement>().gameObject;
        ball.AddComponent<BallTrail>();
    }
}
