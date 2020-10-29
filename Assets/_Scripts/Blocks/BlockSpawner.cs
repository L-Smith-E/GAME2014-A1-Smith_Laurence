/*-------------------Header---------------------
 * BlockSpawner.cs
 * Laurence Smith
 * 101119045
 * Date Last Modified: 28-10-2020
 * Creates and manages block types
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    private float timer = 10.0f;

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

        timer -= Time.deltaTime;

        

        if (block == null)
        {
            b = true;
        }
        
        
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
                if (timer <= 0.0f)
                {
            ScoreSystem.currentscore += 100;
                }
                    break;
                case 2:
                    _block(Regular);
                    timer -= Time.deltaTime;
                    if (timer <= 0.0f)
                    {
                        ScoreSystem.currentscore += 100 * ScoreSystem.scoreMp;
                    }
                    break;
                case 3:
                    _block(Red);
                    timer -= Time.deltaTime;
                    if (timer <= 0.0f)
                    {
                        ScoreSystem.currentscore += 100 * ScoreSystem.scoreMp;
                    }
                    break;
                case 4:
                    _block(Purple);
                    timer -= Time.deltaTime;
                    if (timer <= 0.0f)
                    {
                        ScoreSystem.currentscore += 100 * ScoreSystem.scoreMp;
                    }
                    break;
                case 5:
                    _block(Gold);
                    timer -= Time.deltaTime;
                    if (timer <= 0.0f)
                    {
                        ScoreSystem.currentscore += 100 * ScoreSystem.scoreMp;
                    }
                    break;
                case 6:
                    _block(Bomb);
                    timer -= Time.deltaTime;
                    if (timer <= 0.0f)
                    {
                        ScoreSystem.currentscore += 100 * ScoreSystem.scoreMp;
                    }
                    break;
                case 7:
                    _block(Ghost);
                    timer -= Time.deltaTime;
                    if (timer <= 0.0f)
                    {
                        ScoreSystem.currentscore += 100 * ScoreSystem.scoreMp;
                    }
                    break;
                case 8:
                    _block(Reverse);
                    timer -= Time.deltaTime;
                    if (timer <= 0.0f)
                    {
                        ScoreSystem.currentscore += 100 * ScoreSystem.scoreMp;
                    }
                    break;
                case 9:
                    _block(Freeze);
                    timer -= Time.deltaTime;
                    if (timer <= 0.0f)
                    {
                        ScoreSystem.currentscore += 100 * ScoreSystem.scoreMp;
                    }
                    break;
                case 10:
                    _block(Score2);
                    timer -= Time.deltaTime;
                    if (timer <= 0.0f)
                    {
                        ScoreSystem.currentscore += 100 * ScoreSystem.scoreMp;
                    }
                    break;
                case 11:
                    _block(Score3);
                    timer -= Time.deltaTime;
                    if (timer <= 0.0f)
                    {
                        ScoreSystem.currentscore += 100 * ScoreSystem.scoreMp;
                    }
                    break;
            }

            spawnTime = Time.time + rate;
            
            if (b == true)
            {
                ScoreSystem.currentscore += 100;
                b = false;
            }

            
        }
    }
        
}
