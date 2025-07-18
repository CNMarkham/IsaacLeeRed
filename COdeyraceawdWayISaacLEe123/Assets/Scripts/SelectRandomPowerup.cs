using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SelectRandomPowerup : MonoBehaviour
{
    public List<GameObject> PowerupList;
    public int randomNumberInList;
    public GameObject chosenPowerup;
    public string RealPowerup;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject chosenPowerupClone = Instantiate(chosenPowerup, transform.position, transform.rotation);
            chosenPowerup = PowerupList[0];
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("itemBoxes"))
        {
            randomNumberInList = Random.Range(1, PowerupList.Count);
            chosenPowerup = PowerupList[randomNumberInList];
        }
    }
}
