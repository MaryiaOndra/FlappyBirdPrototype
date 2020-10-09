using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 4.0f;
    private float leftBound = -12f;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerControllerScript.isGameOver)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed, Space.World);
        }

        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }        
    }
}
