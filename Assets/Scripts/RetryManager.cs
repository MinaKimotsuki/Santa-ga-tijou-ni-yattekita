using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
