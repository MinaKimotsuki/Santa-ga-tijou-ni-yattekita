using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseGenerator : MonoBehaviour
{
    [SerializeField] GameObject[] houses = new GameObject[7];

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            int r = Random.Range(0, houses.Length);
            Instantiate(houses[r], new Vector3((6 * i) - 6, 0, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
