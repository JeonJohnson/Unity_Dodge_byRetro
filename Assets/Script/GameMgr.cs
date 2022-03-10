using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMgr : MonoBehaviour
{
    static public GameMgr instance = null;


    public GameObject gameOverText;
    public Text     timeText;
    //public Text recordText;

    private float   surviveTime = 0f;
    private bool    isGameOver = false;

    public void GameEnd()
	{
        isGameOver = true;
        gameOverText.SetActive(true);


    }

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        gameOverText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            surviveTime += Time.deltaTime;
            timeText.text = "Time : " + (int)surviveTime;
        }
        else
        {
           

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene"); 
            }
        }

    }
}
