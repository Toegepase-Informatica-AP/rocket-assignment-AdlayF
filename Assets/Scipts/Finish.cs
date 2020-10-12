using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    
    public Button button;
    public Text text;
    public Text score;
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            if (score.text == "3")
            {
                text.text = "3 coins! Golden medal!";
            }
            else if (score.text == "2")
            {
                text.text = "2 coins! Silver medal!";
            }
            else if (score.text == "1")
            {
                text.text = "1 coin! Bronze medal! ";
            }
            else
                text.text = "At least you finished!";
            Destroy(GameObject.FindGameObjectWithTag("Enemy"));
            var player = GameObject.FindGameObjectWithTag("Player");
            player.SetActive(false);
            GameObject.FindGameObjectWithTag("Score").SetActive(false);
            text.gameObject.SetActive(true);
            button.gameObject.SetActive(true);


        }
      
    }
   
}
