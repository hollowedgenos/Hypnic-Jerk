using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextDiscard : MonoBehaviour
{
    private UIManager uiManager;

    void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (uiManager.powerUpKick == true)
        {
            Invoke(nameof(DisableText), 8f);
            uiManager.powerUpKick = false;
        }
    }

    // Disable the KickPowerUpGet Text
    // Yes I am aware my code is a mess, this is the only thing that works atm.
    void DisableText()
    {
        gameObject.GetComponent<TextMeshProUGUI>().enabled = false;
    }
}
