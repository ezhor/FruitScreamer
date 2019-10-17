using UnityEngine;

public class TargetController : MonoBehaviour
{
    public GameController gameController;
    public float threshold;

    private MicrophoneListener microphoneListener;

    private void Start()
    {
        this.microphoneListener = this.GetComponent<MicrophoneListener>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(microphoneListener.soundValue);
        if (gameController.Playing() && microphoneListener.soundValue > threshold)
        {            
            other.GetComponent<FruitController>()?.Freeze();
            gameController.IncreaseScore();
        }
    }
}