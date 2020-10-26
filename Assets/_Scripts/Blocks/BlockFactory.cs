using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BlockFactory : MonoBehaviour
{
    [Header("Block Types")]
    public GameObject blankBlock;
    public GameObject regularBlock;
    public GameObject redBlock;
    public GameObject purpleBlock;
    public GameObject goldBlock;

    public GameObject createBlock(BlockType type = BlockType.RANDOM)
    {
        if (type == BlockType.RANDOM)
        {
            var randomBLOCK = Random.Range(0, 4);
            type = (BlockType)randomBLOCK;
        }

        GameObject tempBlock = null;
        switch (type)
        {
            case BlockType.BLANK:
                tempBlock = Instantiate(blankBlock);
                tempBlock.GetComponent<BlockController>().damage = 0;
                break;
            case BlockType.REGULAR:
                tempBlock = Instantiate(regularBlock);
                tempBlock.GetComponent<BlockController>().damage = 10 ;
                break;
            case BlockType.RED:
                tempBlock = Instantiate(redBlock);
                tempBlock.GetComponent<BlockController>().damage = 15;
                break;
            case BlockType.PURPLE:
                tempBlock = Instantiate(purpleBlock);
                tempBlock.GetComponent<BlockController>().damage = 20;
                break;
            case BlockType.GOLD:
                tempBlock = Instantiate(goldBlock);
                tempBlock.GetComponent<BlockController>().damage = 30;
                break;
        }

        tempBlock.transform.parent = transform;
        tempBlock.SetActive(false);

        return tempBlock;
    }
}
