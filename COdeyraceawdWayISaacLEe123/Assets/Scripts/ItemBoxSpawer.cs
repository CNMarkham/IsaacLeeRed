using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoxSpawer : MonoBehaviour
{
    public GameObject itemBoxSpawer;
    public GameObject itemBox;

    public int numberOfBoxes;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 BoxPosition = transform.position;
        for (int i = 0; i < numberOfBoxes; i++)
        {
            GameObject itemBoxClone = Instantiate(itemBox);

//            itemBox.transform.position == BoxPosition
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
