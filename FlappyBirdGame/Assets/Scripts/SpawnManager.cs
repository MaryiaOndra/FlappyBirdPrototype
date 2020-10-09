using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //public GameObject obstacleTop;
    //public GameObject obstacleBottom;

    public GameObject obstaclePrefab;

    private float startDelay = 1f;
    private float repeatRate = 2f;
    private float bound = 12f;

    private Vector2 spawnPos = new Vector2();
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnObstacle() 
    {
        if (!playerControllerScript.isGameOver)
        {
            spawnPos.x = bound;
            spawnPos.y = Random.Range(-2, 3);
            Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
        }
    }
}
