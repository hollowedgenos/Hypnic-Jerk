using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDestroy : MonoBehaviour
{

    [SerializeField] GameObject mask;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            Destroy(gameObject);
            mask.SetActive(true);
        }
    }
}
