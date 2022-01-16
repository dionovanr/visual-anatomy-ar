using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    public void penjelasanTulangManusia()
    {
        AudioManager.singleton.stopSound();
        AudioManager.singleton.PlaySound(0);
    }

    public void penjelasanHati()
    {
        AudioManager.singleton.stopSound();
        AudioManager.singleton.PlaySound(2);
    }

    public void penjelasanPankreas()
    {
        AudioManager.singleton.stopSound();
        AudioManager.singleton.PlaySound(5);
    }

    public void penjelasanParuparu()
    {
        AudioManager.singleton.stopSound();
        AudioManager.singleton.PlaySound(6);
    }

    public void penjelasanJantung()
    {
        AudioManager.singleton.stopSound();
        AudioManager.singleton.PlaySound(7);
    }

    public void penjelasanLambung()
    {
        AudioManager.singleton.stopSound();
        AudioManager.singleton.PlaySound(8);
    }

    public void penjelasanUsusBesar()
    {
        AudioManager.singleton.stopSound();
        AudioManager.singleton.PlaySound(9);
    }

    public void penjelasanTulangKepala()
    {
        AudioManager.singleton.stopSound();
        AudioManager.singleton.PlaySound(10);
    }

    public void penjelasanGinjal()
    {
        AudioManager.singleton.stopSound();
        AudioManager.singleton.PlaySound(1);
    }

    public void penjelasanTulangLengan()
    {
        AudioManager.singleton.stopSound();
        AudioManager.singleton.PlaySound(3);
    }

    public void penjelasanTulangRusuk()
    {
        AudioManager.singleton.stopSound();
        AudioManager.singleton.PlaySound(4);
    }

    public void stopAudio()
    {
        AudioManager.singleton.stopSound();
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
