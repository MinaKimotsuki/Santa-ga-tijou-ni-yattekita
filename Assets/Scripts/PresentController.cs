using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentController : MonoBehaviour
{
    float time;
    BoxCollider2D boxCollider2D;
    bool isBoxCollider2DChanged = false;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
        boxCollider2D.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (time <= 1.8f)
        {
            time += Time.deltaTime;
        }
        else
        {
            if (!isBoxCollider2DChanged)
            {
                boxCollider2D.enabled = true;
                isBoxCollider2DChanged = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<SpriteRenderer>().sortingOrder = 0;
        Destroy(gameObject, 0.1f);
    }
}
