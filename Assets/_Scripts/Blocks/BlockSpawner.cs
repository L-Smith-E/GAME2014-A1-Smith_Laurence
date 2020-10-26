using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public BlockManager blockManager;
    public GameObject Blank, Regular, Red, Purple, Gold;

    public float rate;
    public float spawnTime = 0f;
    public int Type;
    // Start is called before the first frame update
    void Start()
    {
     
        //dropBlock();
    }

    private void dropBlock()
    {
       // Instantiate (blockManager.GetBlock(transform.position), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime)
        {
            //dropBlock();
            rate = Random.Range(2.0f, 9.0f);
            Type = Random.Range(1, 5);
            Debug.Log(Type);

            switch (Type)
            {
                case 1:
                    Instantiate(Blank, (transform.position), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(Regular, transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(Red, transform.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(Purple, transform.position, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(Gold, transform.position, Quaternion.identity);
                    break;
            }

            spawnTime = Time.time + rate;
        }
        
    }
}
