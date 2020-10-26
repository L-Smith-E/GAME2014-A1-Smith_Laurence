using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    [Header ("Player Speed")]
    public float moveSpeed = 15.0f;


    private Vector3 touchPosition;
    private Rigidbody2D rb;
    private Vector3 direction;
    

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
