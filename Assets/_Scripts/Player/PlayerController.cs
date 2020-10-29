/*-------------------Header---------------------
 * PlayerController.cs
 * Laurence Smith
 * 101119045
 * Date Last Modified: 28-10-2020
 * Controls the Player
 * Enables Powerups, controls triggers
 */
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    
    [Header ("Player Speed")]
    public float moveSpeed = 15.0f;

    

    private Vector3 touchPosition;
    private Rigidbody2D rb;
    private Vector3 direction;
    private string b_tag;
    public float timer = 3;
    public bool Ghost = false;
    public bool GhostActive = false;


    //public AudioClip bombAudio;
    //public AudioClip freezeAudio;
    //public AudioClip ghostAudio;
    //public AudioClip reverseAudio;
    //public AudioClip scoreAudio;
    //public AudioSource audio;

    public BlockSpawner block;

    private void _bomb()
    {
        var rgBlocks = GameObject.FindGameObjectsWithTag("RegularBlock");
        var rBlocks = GameObject.FindGameObjectsWithTag("RedBlock");
        var pBlocks = GameObject.FindGameObjectsWithTag("PurpleBlock");
        var gBlocks = GameObject.FindGameObjectsWithTag("GoldBlock");
        var bBlocks = GameObject.FindGameObjectsWithTag("BlankBlock");

        foreach (GameObject blocks in rgBlocks)
        {
            Destroy(blocks);
            ScoreSystem.currentscore += 100 * ScoreSystem.scoreMp;
        }
        foreach (GameObject blocks in rBlocks)
        {
            Destroy(blocks);
            ScoreSystem.currentscore += 100 * ScoreSystem.scoreMp;
        }
        foreach (GameObject blocks in pBlocks)
        {
            Destroy(blocks);
            ScoreSystem.currentscore += 100 * ScoreSystem.scoreMp;
        }
        foreach (GameObject blocks in gBlocks)
        {
            Destroy(blocks);
            ScoreSystem.currentscore += 100 * ScoreSystem.scoreMp;
        }
        foreach (GameObject blocks in bBlocks)
        {
            Destroy(blocks);
            ScoreSystem.currentscore += 100 * ScoreSystem.scoreMp;
        }
    }

    private void _freeze()
    {
        var rgBlocks = GameObject.FindGameObjectsWithTag("RegularBlock");
        var rBlocks = GameObject.FindGameObjectsWithTag("RedBlock");
        var pBlocks = GameObject.FindGameObjectsWithTag("PurpleBlock");
        var gBlocks = GameObject.FindGameObjectsWithTag("GoldBlock");
        var bBlocks = GameObject.FindGameObjectsWithTag("BlankBlock");

        foreach (GameObject blocks in rgBlocks)
        {
           // blocks.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0f;
            this.GetComponent<Rigidbody2D>().gravityScale = 0f;
        }
        foreach (GameObject blocks in rBlocks)
        {
            //blocks.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0f;
            this.GetComponent<Rigidbody2D>().gravityScale = 0f;
        }
        foreach (GameObject blocks in pBlocks)
        {
            //blocks.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0f;
            this.GetComponent<Rigidbody2D>().gravityScale = 0f;
        }
        foreach (GameObject blocks in gBlocks)
        {
            //blocks.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0f;
            this.GetComponent<Rigidbody2D>().gravityScale = 0f;
        }
        foreach (GameObject blocks in bBlocks)
        {
            //blocks.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0f;
            this.GetComponent<Rigidbody2D>().gravityScale = 0f;
        }
    }

    private void _ghost()
    {

       while (timer >= -1 && GhostActive == true)
        {
         if (timer > 0)
        {
                GetComponent<Collider>().isTrigger = false;
                Debug.Log(" Timer is: " + timer);
        }

        if (timer == 0)
        {
                GetComponent<Collider>().isTrigger = true;
                Debug.Log(" Timer is: " + timer);
        }
            timer -= Time.deltaTime;
        }
        if (timer == -1)
        {
            GhostActive = false;
            timer = 3;
            
        }
    }

    private void _reverse()
    {
        var rgBlocks = GameObject.FindGameObjectsWithTag("RegularBlock");
        var rBlocks = GameObject.FindGameObjectsWithTag("RedBlock");
        var pBlocks = GameObject.FindGameObjectsWithTag("PurpleBlock");
        var gBlocks = GameObject.FindGameObjectsWithTag("GoldBlock");
        var bBlocks = GameObject.FindGameObjectsWithTag("BlankBlock");

        foreach (GameObject blocks in rgBlocks)
        {
            blocks.transform.position += new Vector3(0.0f, 8, 0.0f) * Time.deltaTime;
        }
        foreach (GameObject blocks in rBlocks)
        {
            blocks.transform.position += new Vector3(0.0f, 8, 0.0f) * Time.deltaTime;
        }
        foreach (GameObject blocks in pBlocks)
        {
            blocks.transform.position += new Vector3(0.0f, 8, 0.0f) * Time.deltaTime;
        }
        foreach (GameObject blocks in gBlocks)
        {
            blocks.transform.position += new Vector3(0.0f, 8, 0.0f) * Time.deltaTime;
        }
        foreach (GameObject blocks in bBlocks)
        {
            blocks.transform.position += new Vector3(0.0f, 8, 0.0f) * Time.deltaTime;
        }
    }

    private void _Score2()
    {
        ScoreSystem.scoreMp = 2;
        Debug.Log("x2");
    }

    private void _Score3()
    {
        ScoreSystem.scoreMp = 3;
        Debug.Log("x3");
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        //if (Ghost == false)
        //{
        b_tag = col.gameObject.tag;

        Debug.Log("trigger");

        col.isTrigger = false;
        switch (b_tag)
        {
            
            case "RegularBlock":
                HealthSystem.hp -= 5f;
                Debug.Log(HealthSystem.hp);
                Destroy(col.gameObject);
                break;

            case "RedBlock":
                HealthSystem.hp -= 10;
                Debug.Log(HealthSystem.hp);
                Destroy(col.gameObject);
                break;

            case "PurpleBlock":
                HealthSystem.hp -= 15;
                Debug.Log(HealthSystem.hp);
                Destroy(col.gameObject);
                break;

            case "GoldBlock":
                HealthSystem.hp -= 25;
                Debug.Log(HealthSystem.hp);
                Destroy(col.gameObject);
                break;
            case "Bomb":
                _bomb();
                Destroy(col.gameObject);
                //Audio._bombA();
                break;
            case "freeze":
                _freeze();
                Destroy(col.gameObject);
                //Audio._play(freezeAudio);
                break;
            case "ghostBlock":
                Destroy(col.gameObject);
                GhostActive = true;
                _ghost();
                break;
            case "Score2":
                _Score2();
                Destroy(col.gameObject);
                break;
            case "Score3":
                _Score3();
                Destroy(col.gameObject);
                break;
            //case "ReverseBlock":
            //    _reverse();
            //    Destroy(col.gameObject);
            //    break;
         }
        //}
        
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(t.position);
            touchPosition.z = 0;
            direction = (touchPosition - transform.position);
            rb.velocity = new Vector2 (direction.x, direction.y) * moveSpeed;

            if (t.phase == TouchPhase.Ended)
            {
                rb.velocity = Vector2.zero;
            }

        }

        
    }
}
