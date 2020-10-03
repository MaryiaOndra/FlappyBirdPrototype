using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstacleTop;
    public GameObject obstacleBottom;
    private float startDelay = 3f;
    private float repeatRate = 2f;
    private float differenceBtwnCenters = 10f;

    public float flyInterval = 3f;
    private float startBound = 15f;
    private Vector3 spawnTopPos = new Vector3();
    private Vector3 spawnBotPos = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle() 
    {
        spawnTopPos.x = startBound;
        spawnBotPos.x = startBound;

        ///TODO: solve repeating problem
        
        spawnTopPos.y = Random.Range(3.0f, 8.0f);
        spawnBotPos.y = spawnTopPos.y - differenceBtwnCenters - flyInterval;

        Instantiate(obstacleTop, spawnTopPos, Quaternion.identity);
        Instantiate(obstacleBottom, spawnBotPos, Quaternion.identity);
    }
}
