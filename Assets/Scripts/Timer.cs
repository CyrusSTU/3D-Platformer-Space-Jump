using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI textObject;
    // Update is called once per frame
    void Update()
    {
        // Set text to current time played in this format: MM:SS:MSS
        textObject.text = string.Format("{0:0}:{1:00}:{2:00}", Mathf.Floor(Time.time / 60), Mathf.Floor(Time.time % 60), Mathf.Floor((Time.time * 100) % 100));
    }
}