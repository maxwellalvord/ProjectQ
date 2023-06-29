using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    [SerializeField] float mainThrust = 1f;
    

    Rigidbody rb; 

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        ProcessThrust();
    }

    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            StartThursting();
        }
      
    }

    void StartThursting()
    {
        rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
        }
    }