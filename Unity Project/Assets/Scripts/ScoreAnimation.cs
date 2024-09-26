using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreAnimation : MonoBehaviour
{
    TMP_Text player1Score;
    TMP_Text player2Score;
    Rigidbody2D rb;
    GameObject ball;
    GameObject wallLeft;
    GameObject wallRight;
    GameObject ballScript;
    CircleCollider2D ballCollider;
    Collider2D wallLeftCollider;
    Collider2D wallRightCollider;


    // Start is called before the first frame update
    void Start()
    {
        player2Score = GameObject.Find("Player1Score").GetComponent<TMP_Text>();
        player1Score = FindFirstObjectByType<TMP_Text>();
        ball = FindFirstObjectByType<GameObject>();
        wallLeft = GameObject.FindGameObjectWithTag("BoundLeft");
        wallRight = GameObject.FindGameObjectWithTag("BoundRight");
        rb = ball.GetComponent<Rigidbody2D>();
        //kijkt of de variabelen leeg zijn
        if (ball == null) print("Ball not found");
        if (rb == null) print("RigidBody not found");
        if (wallLeft == null) print("BoundLeft not found");
        if (wallRight == null) print("BoundRight not found");
    }

    // Update is called once per frame
    void Update()
    {
        CollisionCheck();
    }

    private void CollisionCheck()
    {
        ballCollider = ball.GetComponent<CircleCollider2D>();
        wallLeftCollider = wallLeft.GetComponent<Collider2D>();
        wallRightCollider = wallRight.GetComponent<Collider2D>();

        if (ballCollider.IsTouching(wallRightCollider))
        {
            StartCoroutine(WallP1Remover());
            print("P1");
        }
        else if (ballCollider.IsTouching(wallLeftCollider))
        {
            StartCoroutine(WallP2Remover());
            print("P2");
        }
    }
    IEnumerator WallP2Remover()
    {
        Vector3 originalScale = new Vector3(200, 10, 1);//the muurs original size
        Vector3 targetScale = Vector3.zero;//the size waar de muur naar toe gaat
        float duration = 1f;//tijdsduur van het (shrinking) effect
        float elapsedTime = 0f;//de tijd die is voorbijgegaan

        print("de muur verkleint");
        while (elapsedTime < duration)//blijft loopen zolang elapsed time niet groter is dan duration
        {
            wallLeft.transform.localScale = Vector3.Lerp(originalScale, targetScale, elapsedTime / duration);//Lerp berekent hier hoeveel het moet krimpen op de frame
            //Lerp interpoleert tussen a en b met t als clamp t is altijd tussen 0 en 1 0 is a , 1 is b 0,5 returned het middenpunt van a en b
            elapsedTime += Time.deltaTime;//voegt deltaTime toe aan elapsedTime
            yield return null;//zorgt dat de loop wacht tot het volgende frame tot die weer kleiner wordt gemaakt
        }
        wallLeft.transform.localScale = targetScale;
        print("muur is nu klein");

        yield return new WaitForSeconds(0.2f);//wacht voor 0.2 seconden

        print("terug aan het groeien");
        elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            wallLeft.transform.localScale = Vector3.Lerp(targetScale, originalScale, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        wallLeft.transform.localScale = originalScale;//zet de scale van de muur weer terug naar de original size
        print("muur is nu terug naar original size");
    }
    IEnumerator WallP1Remover()
    {
        Vector3 originalScale = new Vector3(200, 10, 1);
        Vector3 targetScale = Vector3.zero;
        float duration = 1f;
        float elapsedTime = 0f;

        print("de muur verkleint");
        while (elapsedTime < duration)
        {
            wallRight.transform.localScale = Vector3.Lerp(originalScale, targetScale, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        wallRight.transform.localScale = targetScale;
        print("muur is nu klein");

        yield return new WaitForSeconds(0.2f);

        print("terug aan het groeien");
        elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            wallRight.transform.localScale = Vector3.Lerp(targetScale, originalScale, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        wallRight.transform.localScale = originalScale;
        print("muur is nu terug naar original size");
    }
}
