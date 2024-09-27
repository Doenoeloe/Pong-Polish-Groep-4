using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public bool ballBounced;
    public int randNum;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        randNum = Random.Range(0, 7);
        ballBounced = true;
    }
}
