using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBallTrailToBall : MonoBehaviour
{
    GameObject ball;

    private void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Player");
        ball.AddComponent<BallTrail>();
    }
}
