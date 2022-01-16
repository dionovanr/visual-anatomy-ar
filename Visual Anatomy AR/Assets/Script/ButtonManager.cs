using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject buttonAudio, buttonMute;
    public float time;

    public void changeTheButton()
    {
        Invoke("changeButtonIcon", time);
    }

    public void changeButtonIcon()
    {
        buttonAudio.SetActive(true);
        buttonMute.SetActive(false);
    }

}
