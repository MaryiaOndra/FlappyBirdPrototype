using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 5f;
    private float lowerBound = -12f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);

        if (transform.position.x < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
