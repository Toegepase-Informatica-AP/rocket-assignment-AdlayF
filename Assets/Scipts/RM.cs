using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RM : MonoBehaviour
{
    [SerializeField] float rcsThrust = 100f;
    [SerializeField] float shipThrust = 100f;

    Rigidbody rigidBody;

    void Start()
    {

        rigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

        Thrust();
        Rotate();
        float d = Quaternion.Dot(transform.rotation, Quaternion.identity);

       if(d < .72f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void Thrust()
    {


        float thrustThisFrame = shipThrust * Time.deltaTime;

        if (Input.GetKey(KeyCode.Space))
        {
      
            rigidBody.AddRelativeForce(Vector3.up * thrustThisFrame);

        }

    }

    private void Rotate()
    {

        float rotationThisFrame = rcsThrust * Time.deltaTime;

      
        float h = Input.GetAxis("Horizontal")*rotationThisFrame;
        transform.Rotate(Vector3.forward * h);
        if(h == 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, Time.fixedDeltaTime);
        }
       
    }

}
