using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public bool isOnGround = false;
    public bool isGameOver = false;  
    public float speed = 2.0f;
    public Text scoreText;

    private int countScore = 0;
    private float upForce = 50.0f;
    private float topPosY = 6.0f;
    private Rigidbody2D playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        scoreText.text = countScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerRb.position.y > topPosY)
        {
            playerRb.position = new Vector2(playerRb.position.x, topPosY);
            isGameOver = true;
        }

        if (Input.GetKey(KeyCode.Space) && !isGameOver)
        {
            playerRb.AddForce(Vector2.up * upForce, ForceMode2D.Force);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("GAME OVER");
            isGameOver = true;
            playerRb.constraints = RigidbodyConstraints2D.None;
        }
        else if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Is on the ground");
            isOnGround = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ScorePoint"))
        {
            countScore++;
            scoreText.text = countScore.ToString();
        }
    }
}

