using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public bool ballBounced;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ballBounced = true;
    }
}
