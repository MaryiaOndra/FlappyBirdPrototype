using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public bool isOnGround = false;
    public bool isGameOver = false;

    private float upForce = 5.0f;
    private Rigidbody2D playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerRb.AddForce(Vector2.right * upForce, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            playerRb.AddForce(Vector2.up * upForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("GAME OVER");
            isGameOver = true;
        }
        else if (other.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Is on the ground");
            isOnGround = true;
        }
    }

}

