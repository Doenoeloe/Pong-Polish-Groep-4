using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHittingPlayerImpactFrame : MonoBehaviour
{
    [SerializeField] GameObject rightPlayer = null;
    [SerializeField] GameObject leftPlayer = null;

    public GameObject wallUp;
    public GameObject wallDown;
    public GameObject wallLeft;
    public GameObject wallRight;

    public GameObject ballMovementScript;

    public GameObject ball;

    void Start()
    {
        if (ballMovementScript == null)
        {
            return;
        }
        else
        {
            ballMovementScript.AddComponent<BallHittingPlayerImpactFrame>();
            wallUp = GameObject.Find("WallUp");
            wallDown = GameObject.Find("WallDown");
            wallLeft = GameObject.Find("WallLeft");
            wallRight = GameObject.Find("WallRight");
            rightPlayer = GameObject.Find("PlayerRight");
            leftPlayer = GameObject.Find("PlayerLeft");

            ball = FindFirstObjectByType<GameObject>();

            GameObject wallUp2 = GameObject.Find("WallUp");
            GameObject wallDown2 = GameObject.Find("WallDown");
            GameObject wallRight2 = GameObject.Find("WallRight");
            GameObject wallLeft2 = GameObject.Find("WallLeft");
            GameObject rightPlayer2 = GameObject.Find("PlayerRight");
            GameObject leftPlayer2 = GameObject.Find("PlayerLeft");
            GameObject ball2 = GameObject.Find("Ball");

            ball.GetComponent<BallHittingPlayerImpactFrame>().wallUp = wallUp2;
            ball.GetComponent<BallHittingPlayerImpactFrame>().wallDown = wallDown2;
            ball.GetComponent<BallHittingPlayerImpactFrame>().wallRight = wallRight2;
            ball.GetComponent<BallHittingPlayerImpactFrame>().wallLeft = wallLeft2;
            ball.GetComponent<BallHittingPlayerImpactFrame>().rightPlayer = rightPlayer2;
            ball.GetComponent<BallHittingPlayerImpactFrame>().leftPlayer = leftPlayer2;
            ball.GetComponent<BallHittingPlayerImpactFrame>().ball = ball2;
        }
    }


    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == leftPlayer)
        {
            StartCoroutine(ImpactFrameEffect());
        }
        else if (collision.gameObject == rightPlayer)
        {
            StartCoroutine(ImpactFrameEffect());
        }
    }

    IEnumerator ImpactFrameEffect()
    {
        Camera.main.backgroundColor = Color.white;
        Renderer wallUpRenderer = wallUp.GetComponent<Renderer>();
        Renderer wallDownRenderer = wallDown.GetComponent<Renderer>();
        Renderer wallLeftRenderer = wallLeft.GetComponent<Renderer>();
        Renderer wallRightRenderer = wallRight.GetComponent<Renderer>();
        Renderer rightPlayerRenderer = rightPlayer.GetComponent<Renderer>();
        Renderer leftPlayerRenderer = leftPlayer.GetComponent<Renderer>();
        Renderer ballRenderer = ball.GetComponent<Renderer>();

        wallUpRenderer.material.color = Color.black;
        wallDownRenderer.material.color = Color.black;
        wallLeftRenderer.material.color = Color.black;
        wallRightRenderer.material.color = Color.black;
        rightPlayerRenderer.material.color = Color.black;
        leftPlayerRenderer.material.color = Color.black;
        ballRenderer.material.color = Color.black;

        Time.timeScale = 0.4f;
        yield return new WaitForSeconds(0.2f);
        Time.timeScale = 1;

        Camera.main.backgroundColor = Color.black;
        wallUpRenderer.material.color = Color.white;
        wallDownRenderer.material.color = Color.white;
        wallLeftRenderer.material.color = Color.white;
        wallRightRenderer.material.color = Color.white;
        rightPlayerRenderer.material.color = Color.white;
        leftPlayerRenderer.material.color = Color.white;
        ballRenderer.material.color = Color.white;
    }
}