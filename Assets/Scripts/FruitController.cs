using UnityEngine;

public class FruitController : MonoBehaviour
{
    public void Freeze()
    {
        Destroy(this.GetComponent<Collider>());
        Destroy(this.GetComponent<Rigidbody>());
        Destroy(this);
    }
}
