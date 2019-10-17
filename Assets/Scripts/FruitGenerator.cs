using System.Collections;
using UnityEngine;

public class FruitGenerator : MonoBehaviour
{
    public GameController gameController;
    public Transform fruitsParent;
    public GameObject[] fruits;

    private static readonly float delay = 1f;

    void Start()
    {
        StartCoroutine(GenerateObjectCoroutine());
    }

    private IEnumerator GenerateObjectCoroutine()
    {
        while (gameController.Playing())
        {
            GenerateObject();
            yield return new WaitForSeconds(delay);
        }
    }

    public void GenerateObject()
    {
        int fixedSize = 10;
        GameObject instance = Instantiate(RandomFruit(), RandomPosition(), Random.rotation, fruitsParent);
        instance.transform.localScale = new Vector3(fixedSize, fixedSize, fixedSize);
        instance.AddComponent<Rigidbody>();
        instance.AddComponent<FruitController>();
        instance.GetComponent<Collider>().isTrigger = true;
    }

    private Vector3 RandomPosition()
    {
        int bound = 4;
        return new Vector3(Random.Range(-bound, bound), this.transform.position.y, Random.Range(-bound, bound));
    }

    private GameObject RandomFruit()
    {
        int randomIndex = Random.Range(0, fruits.Length - 1);
        return fruits[randomIndex];
    }
}
