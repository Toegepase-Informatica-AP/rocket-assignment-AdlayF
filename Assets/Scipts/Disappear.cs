using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disappear : MonoBehaviour
{
    public Text score;
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            score.text = (int.Parse(score.text) + 1).ToString("G");
            Destroy(gameObject);
           
        
        }
    }
}
