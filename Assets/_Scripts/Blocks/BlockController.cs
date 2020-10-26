using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    private int rows = 5;
    private int cols = 8;
    private float tileSize = 1.0f;
    public float verticalSpeed;
    public float verticalBoundary;
    public BlockManager blockManager;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        blockManager = FindObjectOfType<BlockManager>();
    }

    // Update is called once per frame
    void Update()
    {
       _GenerateGrid();
       _CheckBounds();
    }

    private void _GenerateGrid()
    {
        //GameObject referenceTile =(GameObject)Instantiate()
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                blockManager.GetBlock(transform.position);

                float posx = col * tileSize;
                float posY = row * -tileSize;
                 _Move();
            }
        }
    }

    private void _Move()
    {
        transform.position += new Vector3(0.0f, -verticalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        if (transform.position.y < verticalBoundary)
        {
            blockManager.ReturnBlock(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        blockManager.ReturnBlock(gameObject);
    }

    public int ApplyDamage()
    {
        return damage;
    }
}
