/*-------------------Header---------------------
 * ScoreSystem.cs
 * Laurence Smith
 * 101119045
 * Date Last Modified: 28-10-2020
 * Manages scoring system
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    Text Score;
   public static int currentscore = 0;
    public static int scoreMp = 1 ;
    // Start is called before the first frame update
    void Start()
    {
         Score = gameObject.GetComponent<Text>();
        
        //GameObject thePlayer = GameObject.Find("ThePlayer");
        ////PlayerController PlayerController = thePlayer.GetComponent<PlayerController>();
        //currentscore = PlayerController.score;
       
    }

    // Update is called once per frame
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "GameOver" )
        {
            Score.text = "Final Score: " + currentscore;
        }

        if (scene.name == "L1")
        {
            Score.text = "Score: " + currentscore;
        }
        

    }
}
