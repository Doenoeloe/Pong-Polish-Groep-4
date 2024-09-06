using UnityEngine;

public class StartGameText : MonoBehaviour
{
    // Dit is een mooie comment, toch?
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
