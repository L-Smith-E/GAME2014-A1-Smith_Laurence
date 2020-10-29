using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBtn : MonoBehaviour
{
    public AudioClip select;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void StartBtnPressed()
    {
        Debug.Log("Start Button Pressed");
        SceneManager.LoadScene("Play");
        //select.Play();
    }
}
