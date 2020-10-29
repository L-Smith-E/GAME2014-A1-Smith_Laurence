/*-------------------Header---------------------
 * Audio.cs
 * Laurence Smith
 * 101119045
 * Date Last Modified: 28-10-2020
 * Manages Audio system
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{

    public AudioSource bombAudio;
    public AudioSource freezeAudio;
    public AudioSource ghostAudio;
    public AudioSource reverseAudio;
    public AudioSource scoreAudio;
    
    // Start is called before the first frame update
    void Start()
    {
        //bombAudio = GetComponent<AudioSource>();
        //freezeAudio = GetComponent<AudioSource>();
        //ghostAudio = GetComponent<AudioSource>();
        //reverseAudio = GetComponent<AudioSource>();
        //scoreAudio = GetComponent<AudioSource>();
    }

    //public void _bombA()
    //{
    //    bombAudio.Play();
    //}

    //public void _freezeA()
    //{
    //    freezeAudio.Play();
    //}

    //public void _ghostA()
    //{
    //    ghostAudio.Play();
    //}

    //public void _reverseA()
    //{
    //    reverseAudio.Play();
    //}

    //public void _scoreA()
    //{
    //    scoreAudio.Play();
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
