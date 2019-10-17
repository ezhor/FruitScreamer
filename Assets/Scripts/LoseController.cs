using UnityEngine;

public class LoseController : MonoBehaviour
{
    public GameController gameController;

    private void OnTriggerEnter(Collider other)
    {
        gameController.Lose();
    }
}
