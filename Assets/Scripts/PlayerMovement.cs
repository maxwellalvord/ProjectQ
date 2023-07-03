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
        ProcessTurm();
    }

    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            StartThursting();
        }
      
    }
     void ProcessTurn()
    {
        if (Input.GetKey(KeyCode.A))
        {
            TurnLeft();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            TurnRight();
        }
       
    }

    void StartThursting()
    {
        rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
        }
    }