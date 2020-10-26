using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BlockManager : MonoBehaviour
{
    public BlockFactory blockFactory;
    public int blockLimit;

    private Queue<GameObject> m_blockPool;


    // Start is called before the first frame update
    void Start()
    {
        _BuildBlockPool();
    }

    private void _BuildBlockPool()
    {
        m_blockPool = new Queue<GameObject>();

        for (int count = 0; count < blockLimit; count++)
        {
            var tempBlock = blockFactory.createBlock();
            m_blockPool.Enqueue(tempBlock);
        }
    }

    public GameObject GetBlock(Vector3 position)
    {
        var newBlock = m_blockPool.Dequeue();
        newBlock.SetActive(true);
        newBlock.transform.position = position;
        return newBlock;
    }

    public void ReturnBlock(GameObject returnedBlock)
    {
        returnedBlock.SetActive(false);
        m_blockPool.Enqueue(returnedBlock);
    }
}
