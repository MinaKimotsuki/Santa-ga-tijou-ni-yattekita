using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour
{
    [SerializeField] Text pointText;

    // Start is called before the first frame update
    void Start()
    {
        pointText.text = GameManager.Point.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnRetryButton()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void OnTitleButton()
    {
        SceneManager.LoadScene("Start");
    }
}
