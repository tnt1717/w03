using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public GameObject menu;
    public GameObject menu1;
    public GameObject menu2;
    public GameObject menu3;
    public GameObject menu4;
    public GameObject menu5;
    public GameObject hpbar;
    public AudioMixer audiomixer;
    public GameObject over;
    public AudioSource bgm;
    public Slider slider;

    void Start()
    {
        menu1.SetActive(false);
        menu2.SetActive(false);
        menu3.SetActive(false);
        menu4.SetActive(false);
        menu5.SetActive(false);
        slider.transform.gameObject.SetActive(false);
    }
    void Update()
    {
        if (Player.HP <= 0)
        {
            over.SetActive(true);
            menu.SetActive(false);
            menu1.SetActive(false);
            menu2.SetActive(false);
            menu3.SetActive(false);
            menu4.SetActive(false);
            menu5.SetActive(true);
        }
        else over.SetActive(false);
        bgm.volume = slider.value;
    }
    public void Menu()
    {
        
        Time.timeScale = 0;
        menu.SetActive(false);
        menu1.SetActive(true);
        menu2.SetActive(true);
        menu3.SetActive(true);
        menu4.SetActive(true);
        slider.transform.gameObject.SetActive(true);
        hpbar.SetActive(false);

    }
    public void cont()
    {
        Time.timeScale = 1;
        menu.SetActive(true);
        menu1.SetActive(false);
        menu2.SetActive(false);
        menu3.SetActive(false);
        menu4.SetActive(false);
        hpbar.SetActive(true);
        slider.transform.gameObject.SetActive(false);

    }
    public void exit()
    {
        Application.Quit();
    }
    public void home()
    {
        SceneManager.LoadScene("menu");
    }
    public void start()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1;
        GameManager.score = 0;
        hpbar.SetActive(true);
    }
    public void restart()
    {
        SceneManager.LoadScene("solo");
        Time.timeScale = 1;
        GameManager.score = 0;
        hpbar.SetActive(true);
    }



    public void SetVolume(float volume)
    {
        audiomixer.SetFloat("volume", volume);
        Debug.Log(volume);
    }
}
