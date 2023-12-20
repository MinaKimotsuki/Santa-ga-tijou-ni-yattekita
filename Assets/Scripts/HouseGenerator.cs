using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseGenerator : MonoBehaviour
{
    [SerializeField] GameObject[] houses = new GameObject[6];

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            int r = Random.Range(0, 6);
            float height = Random.Range(-3f, 0f);
            Instantiate(houses[r], new Vector3((6 * i) - 6, height,0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
