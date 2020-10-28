using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    //public BlockManager blockManager;
    public GameObject Blank, Regular, Red, Purple, Gold, 
        Bomb, Freeze, Ghost, Reverse, Score2, Score3;

    [Header("Boundary Check")]
    public float verticalBoundary;

    public float rate;
    public float spawnTime = 0f;
    public int Type;
    private bool b;
    private float tempY;

    // Start is called before the first frame update
    void Start()
    {
    }

    //private void dropBlock()
    //{
    //    blockManager.GetBlock(transform.position);
    //}

    private void  _block(GameObject obj)
    {
        GameObject block = Instantiate(obj, (transform.position), Quaternion.identity);

        //if (b == true)
        //{
        //    Destroy(block);
        //}
        Destroy(block, 10);

    }

    //private void _CheckBounds()
    //{
        
    //}
    // Update is called once per frame
    void Update()   
    {
        //dropBlock();
        //_CheckBounds();
        if (Time.time > spawnTime)
        { 
            rate = Random.Range(2.0f, 9.0f);
            Type = Random.Range(1, 11);
            

            switch (Type)
            {
                case 1:
                    _block(Blank);
                    break;
                case 2:
                    _block(Regular);
                    break;
                case 3:
                    _block(Red);
                    break;
                case 4:
                    _block(Purple);
                    break;
                case 5:
                    _block(Gold);
                    break;
                case 6:
                    _block(Bomb);
                    break;
                case 7:
                    _block(Ghost);
                    break;
                case 8:
                    _block(Reverse);
                    break;
                case 9:
                    _block(Freeze);
                    break;
                case 10:
                    _block(Score2);
                    break;
                case 11:
                    _block(Score3);
                    break;
            }

            spawnTime = Time.time + rate;
        }
    }
        
}
