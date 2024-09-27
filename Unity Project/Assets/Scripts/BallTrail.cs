using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTrail : MonoBehaviour
{
    GameObject leftWall;
    GameObject rightWall;

    TrailRenderer trailRenderer;

    private void Start()
    {
        leftWall = GameObject.FindGameObjectWithTag("BoundLeft");
        rightWall = GameObject.FindGameObjectWithTag("BoundRight");

        trailRenderer = gameObject.AddComponent<TrailRenderer>();

        trailRenderer.material = new Material(Shader.Find("Sprites/Default"));
        trailRenderer.time = 0.2f;
        trailRenderer.startWidth = 0.25f;
        trailRenderer.endWidth = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == leftWall || collision.gameObject == rightWall)
        {
            trailRenderer.enabled = false;
            StartCoroutine(EnableTrailDelay());
        }
    }

    IEnumerator EnableTrailDelay()
    {
        yield return new WaitForSeconds(2f);
        trailRenderer.enabled = true;
    }
}