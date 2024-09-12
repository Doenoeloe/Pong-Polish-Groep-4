using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapColorOnBounce : MonoBehaviour
{
    Camera cam;
    GameObject ball;
    BallBounce BallBounce;

    private Color[] colors = { Color.black, Color.blue, Color.red, Color.green, Color.magenta, Color.yellow, Color.cyan, Color.gray };

    private int oldRandNum;

    // Start is called before the first frame update
    void Start()
    {
        cam = FindFirstObjectByType<Camera>();
        ball = FindFirstObjectByType<BallMovement>().gameObject;
        ball.AddComponent<BallBounce>();
        BallBounce = FindFirstObjectByType<BallBounce>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!BallBounce.ballBounced) return;
        BallBounce.ballBounced = false;
        if (BallBounce.randNum == oldRandNum)
        {
            if (BallBounce.randNum == 0) BallBounce.randNum += 1;
            else if (BallBounce.randNum == 7) BallBounce.randNum -= 1;
            else BallBounce.randNum += 1;
        }
        else
        {
            oldRandNum = BallBounce.randNum;
        }
        cam.backgroundColor = colors[BallBounce.randNum];
    }
}
