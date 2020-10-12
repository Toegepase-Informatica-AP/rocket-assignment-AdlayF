using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour
{
    
    public void OnTriggerEnter(Collider collider)
    {
        SceneManager.LoadScene("LevelTwo");
    }
    
}
