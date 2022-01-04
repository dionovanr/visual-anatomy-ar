using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void penjelasanTulangManusia()
    {
        AudioManager.singleton.stopSound();
        AudioManager.singleton.PlaySound(0);
        
    }
}
