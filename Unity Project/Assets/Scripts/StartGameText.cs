using UnityEngine;

public class StartGameText : MonoBehaviour
{
    // Comments zijn niet leuk om te schrijven, maar wel heel handig als ze nuttig zijn.. quak.
    BallMovement ballMovement;
    [SerializeField] GameObject playText;
    void Start()
    {
        ballMovement = FindFirstObjectByType<BallMovement>();
    }

    void Update()
    {
        playText.SetActive(!ballMovement.IsPlaying());
    }
}
