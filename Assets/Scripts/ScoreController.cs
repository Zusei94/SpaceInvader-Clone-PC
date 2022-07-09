using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text timeField;
    public Text highScoreField;
    private float time;
    private float hightTime;
    private bool gameEnd;
    public GameObject player;
    public GameObject replayButton;
    
    // Start is called before the first frame update
    void Start()
    {
        
        hightTime = PlayerPrefs.GetInt("HighScore");
        highScoreField.text = hightTime.ToString();
        Time.timeScale = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameEnd == false)
        {
            time += Time.smoothDeltaTime;
            timeField.text = Convert.ToInt32(time).ToString();
        }
        if (gameEnd == true)
        {
            Time.timeScale = 0;
            if (time > hightTime)
            {
                hightTime = time;
                highScoreField.text = Convert.ToInt32(hightTime).ToString();
                PlayerPrefs.SetInt("HighScore", Convert.ToInt32(hightTime));
            }
            replayButton.SetActive(true);
        }
    }
    private void OnGUI()
    {
        if (player == null)
        {
            gameEnd = true;
        }
    }
}
