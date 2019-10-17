using UnityEngine;

public class TargetController : MonoBehaviour
{
    public GameController gameController;
    public bool screaming = true;

    private void OnTriggerEnter(Collider other)
    {
        if (screaming)
        {
            other.GetComponent<FruitController>()?.Freeze();
            gameController.IncreaseScore();
        }        
    }
}
