using UnityEngine;

public class StartGameText : MonoBehaviour
{
    // Dit is één comment
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
