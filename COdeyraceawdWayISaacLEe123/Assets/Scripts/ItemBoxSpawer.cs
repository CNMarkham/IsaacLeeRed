using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoxSpawer : MonoBehaviour
{
    public GameObject itemBoxSpawer;
    public GameObject itemBox;

    public int numberOfBoxes;

    public float itemBoxSpacing;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 SpawnLocations = itemBox.transform.position;
        

        for (int i = 0; i < numberOfBoxes; i++)
        {
            SpawnLocations.z = +itemBoxSpacing;
            itemBoxSpacing -= 4;

            GameObject itemBoxClone = Instantiate(itemBox, transform.position + SpawnLocations, transform.rotation);

           
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
