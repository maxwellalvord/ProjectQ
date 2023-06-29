using UnityEngine;

public class Movement : MonoBehaviour
{   
    [SerializeField] float mainThrust = 10000000000f;
    

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
