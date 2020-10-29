/*-------------------Header---------------------
 * HealthSystem.cs
 * Laurence Smith
 * 101119045
 * Date Last Modified: 28-10-2020
 * Manages Health System
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class HealthSystem : MonoBehaviour
{
    [Header("Health")]
    Text Health;
    public static float hp = 100f;
    // Start is called before the first frame update
    void Start()
    {
       Health = gameObject.GetComponent<Text>();


    }

    // Update is called once per frame
    void Update()
    {
        Health.text = "Health: " + hp;

        if (hp <= 0f)
        {
            SceneManager.LoadScene("GameOver");
            hp = 100f;
        }
        
    }
}
