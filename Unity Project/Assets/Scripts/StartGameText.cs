using UnityEngine;

public class StartGameText : MonoBehaviour
{
    // comment zijn heel cool
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
