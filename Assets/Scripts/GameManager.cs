using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    float time;
    [SerializeField] GameObject finishPanel;
    [SerializeField] Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        finishPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timeText.text = (60 - time).ToString("f0");
        if (time >= 60f)
        {
            finishPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void OnFinishButton()
    {
        SceneManager.LoadScene("Result");
    }
}
