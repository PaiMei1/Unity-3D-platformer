using UnityEngine;

public class FallingPlatform : MonoBehaviour
{

    [SerializeField] Rigidbody RB;
    [SerializeField] float fallDelay = 2f;


       private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player stepped on the platform. It will fall in " + fallDelay + " seconds.");
            Invoke("Fall", fallDelay);
        }
    }

    void Fall()
    {
        Debug.Log("Platform is falling!");
        RB.isKinematic = false;
        RB.useGravity = true;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
