using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentGenerator : MonoBehaviour
{
    [SerializeField] GameObject presentPrefab;
    [SerializeField] Sprite[] presentTextures = new Sprite[6];
    [SerializeField] GameObject santa;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            int r = Random.Range(0, 6);
            GameObject present = Instantiate(presentPrefab, santa.transform.position + new Vector3(1, 1, 0), Quaternion.identity);
            present.GetComponent<SpriteRenderer>().sprite = presentTextures[r];
        }
    }
}
