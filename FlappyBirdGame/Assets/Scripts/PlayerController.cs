using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private bool isOnGround = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Is on the ground");
        isOnGround = true;
    }
}

