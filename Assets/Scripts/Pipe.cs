using UnityEngine;

public class PipePair : MonoBehaviour
{
    public float moveSpeed = 2;

    void Start()
    {

    }

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
}
