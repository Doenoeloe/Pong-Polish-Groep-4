using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapColorOnBounce : MonoBehaviour
{
    Camera cam;
    GameObject ball;
    BallBounce BallBounce;

    private Color[] colors = { Color.black, Color.blue, Color.red, Color.green, Color.magenta, Color.yellow, Color.cyan, Color.gray };

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
        cam.backgroundColor = colors[Random.Range(0, colors.Length)];
        BallBounce.ballBounced = false;
    }
}
