using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    [Header ("Player Speed")]
    public float moveSpeed = 15.0f;

    private float hp = 100f;
    private Vector3 touchPosition;
    private Rigidbody2D rb;
    private Vector3 direction;
    private string b_tag;


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
        }
        foreach (GameObject blocks in rBlocks)
        {
            Destroy(blocks);
        }
        foreach (GameObject blocks in pBlocks)
        {
            Destroy(blocks);
        }
        foreach (GameObject blocks in gBlocks)
        {
            Destroy(blocks);
        }
        foreach (GameObject blocks in bBlocks)
        {
            Destroy(blocks);
        }
    }

    private void _freeze()
    {

    }

    private void _ghost()
    {

    }

    private void _reverse()
    {

    }

    private void _Score2()
    {

    }

    private void _Score3()
    {

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        b_tag = col.gameObject.tag;

        Debug.Log("trigger");

        col.isTrigger = false;
        switch (b_tag)
        {
            
            case "RegularBlock":
                hp -= 5f;
                Debug.Log(hp);
                Destroy(col.gameObject);
                break;

            case "RedBlock":
                hp -= 10;
                Debug.Log(hp);
                Destroy(col.gameObject);
                break;

            case "PurpleBlock":
                hp -= 15;
                Debug.Log(hp);
                Destroy(col.gameObject);
                break;

            case "GoldBlock":
                hp -= 25;
                Debug.Log(hp);
                Destroy(col.gameObject);
                break;
            case "Bomb":
                _bomb();
                Destroy(col.gameObject);
                break;
         }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
