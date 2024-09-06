using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBallTrailToBall : MonoBehaviour
{
    GameObject ball;

    private void Start()
    {
        ball = FindFirstObjectByType<BallMovement>().gameObject;
        ball.AddComponent<BallTrail>();
    }
}
