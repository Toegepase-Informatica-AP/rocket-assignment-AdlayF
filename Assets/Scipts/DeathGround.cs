using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathGround : MonoBehaviour
{
    public Transform player;
 
    void Update()
    {
        transform.position = new Vector3(player.position.x, transform.position.y, player.position.z);
    }
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
   
}
