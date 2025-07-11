using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TImer : MonoBehaviour
{
    public TMP_Text lapTime;
    public TMP_Text startCountdown;

    public float totalLapTime;
    public float totalCountdownTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalLapTime -= Time.deltaTime;
        totalCountdownTime -= Time.deltaTime;

        lapTime.text = Mathf.Round(totalLapTime).ToString();
        startCountdown.text = Mathf.Round(totalCountdownTime).ToString();

        if(totalCountdownTime < 0 || totalLapTime < 0)
        {
            Debug.Log("Time is Up LOL");
            SceneManager.LoadScene(0);
        }
    }
}
