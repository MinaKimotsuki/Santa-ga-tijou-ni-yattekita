using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentGenerator : MonoBehaviour
{
    [SerializeField] GameObject presentPrefab;
    [SerializeField] GameObject santa;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            GameObject present = Instantiate(presentPrefab, santa.transform.position + new Vector3(1, 1, 0), Quaternion.identity);
            present.GetComponent<Rigidbody2D>().AddForce(new Vector3(200, 600, 0));
        }
    }
}
