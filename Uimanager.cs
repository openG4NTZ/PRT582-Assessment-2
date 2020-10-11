using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
 
using UnityEngine.SceneManagement;

public class Uimanager : MonoBehaviour
{
    public GameObject Watchpage;
    public GameObject Catagory_Panel;
    public GameObject Metal_Panel;
    public GameObject Sport_Panel;
    public GameObject Smart_Panel;
    public GameObject Leather_Panel;
    public GameObject Main_Panel;
    public AudioSource asource;
    public AudioClip aclip1;
    public AudioClip aclip2;

    // Start is called before the first frame update
    void Start()
    {
        Watchpage.GetComponent<WatchesPages>().enabled = false;
        Metal_Panel.SetActive(false);
        Sport_Panel.SetActive(false);
        Smart_Panel.SetActive(false);
        Leather_Panel.SetActive(false);
        Main_Panel.SetActive(true);
        asource.PlayOneShot(aclip1);
    }


    public void back_Smart()
    {
        Smart_Panel.SetActive(false);
        Catagory_Panel.SetActive(true);
        bTN_SOUND();
    }
    public void back_Sport()
    {
        Sport_Panel.SetActive(false);
        Catagory_Panel.SetActive(true);
        bTN_SOUND();
    }
    public void back_Leather()
    {
        Catagory_Panel.SetActive(true);
        Leather_Panel.SetActive(false);
        bTN_SOUND();
    }
    public void back_Metal()
    {
        Catagory_Panel.SetActive(true);
        Metal_Panel.SetActive(false);
        bTN_SOUND();
    }

    public void Open_Smart()
    {
        Catagory_Panel.SetActive(false);
        Smart_Panel.SetActive(true);
        bTN_SOUND();
    }
    public void Open_Sport()
    {
        Sport_Panel.SetActive(true);
        Catagory_Panel.SetActive(false);
        bTN_SOUND();
    }
    public void Open_Leather()
    {
        Leather_Panel.SetActive(true);
        Catagory_Panel.SetActive(false);
        bTN_SOUND();
    }
    public void Open_Metal()
    {
        Metal_Panel.SetActive(true);
        Catagory_Panel.SetActive(false);
        bTN_SOUND();
    }

    public void Open_Catagory()
    {
        Catagory_Panel.SetActive(true);
        Main_Panel.SetActive(false);
        bTN_SOUND();
    }
    public void Open_mainpage()
    {
        Catagory_Panel.SetActive(false);
        Main_Panel.SetActive(true);
        bTN_SOUND();
    }
    public void select_Leather_watch1(int num)
    {
        if (num == 0)
        {
            PlayerPrefs.SetInt("Leather", num);
            SceneManager.LoadScene("Leather_watch_AR");
            Watchpage.GetComponent<WatchesPages>().enabled = true;
            bTN_SOUND();
            Watchpage.GetComponent<WatchesPages>().enabled = true;
        }
        if (num == 1)
        {
            PlayerPrefs.SetInt("Leather", num);
            SceneManager.LoadScene("Leather_watch_AR");
           
           
            bTN_SOUND();
            Watchpage.GetComponent<WatchesPages>().enabled = true;
        }
        if (num == 2)
        {
            PlayerPrefs.SetInt("Leather", num);
            SceneManager.LoadScene("Leather_watch_AR");
            bTN_SOUND();
            Watchpage.GetComponent<WatchesPages>().enabled = true;
        }
        if (num == 3)
        {
            PlayerPrefs.SetInt("Leather", num);
            SceneManager.LoadScene("Leather_watch_AR");
            bTN_SOUND();
            Watchpage.GetComponent<WatchesPages>().enabled = true;
        }
        //======================================================================
       
        //======================================
       
        //==============================================================
     
    }
    public void select_Smart_watch2(int num)
    {
        if (num == 0)
        {
            PlayerPrefs.SetInt("Smart", num);
            SceneManager.LoadScene("Smart_watch_AR");
            bTN_SOUND();
            Watchpage.GetComponent<WatchesPages>().enabled = true;
        }
        if (num == 1)
        {
            PlayerPrefs.SetInt("Smart", num);
            SceneManager.LoadScene("Smart_watch_AR");
            bTN_SOUND();
            Watchpage.GetComponent<WatchesPages>().enabled = true;
        }
        if (num == 2)
        {
            PlayerPrefs.SetInt("Smart", num);
            SceneManager.LoadScene("Smart_watch_AR");
            bTN_SOUND();
            Watchpage.GetComponent<WatchesPages>().enabled = true;
        }
        if (num == 3)
        {
            PlayerPrefs.SetInt("Smart", num);
            SceneManager.LoadScene("Smart_watch_AR");
            bTN_SOUND();
            Watchpage.GetComponent<WatchesPages>().enabled = true;
        }

    }
    public void select_Metal_watch3(int num)
    {

        if (num == 0)
        {
            PlayerPrefs.SetInt("Metal", num);
            SceneManager.LoadScene("Metal_watch_AR");
            bTN_SOUND();
        }
        if (num == 1)
        {
            PlayerPrefs.SetInt("Metal", num);
            SceneManager.LoadScene("Metal_watch_AR");
            bTN_SOUND();
        }
        if (num == 2)
        {
            PlayerPrefs.SetInt("Metal", num);
            SceneManager.LoadScene("Metal_watch_AR");
            bTN_SOUND();
        }
        if (num == 3)
        {
            PlayerPrefs.SetInt("Metal", num);
            SceneManager.LoadScene("Metal_watch_AR");
            bTN_SOUND();
        }
    }
    public void select_Sport_watch4(int num)
    {
        if (num == 0)
        {
            PlayerPrefs.SetInt("Sport", num);
            SceneManager.LoadScene("Sport_watch_AR");
            bTN_SOUND();
        }
        if (num <= 1)
        {
            PlayerPrefs.SetInt("Sport", num);
            SceneManager.LoadScene("Sport_watch_AR");
            bTN_SOUND();
        }
        if (num <= 2)
        {
            PlayerPrefs.SetInt("Sport", num);
            SceneManager.LoadScene("Sport_watch_AR");
            bTN_SOUND();
        }
        if (num <= 3)
        {
            PlayerPrefs.SetInt("Sport", num);
            SceneManager.LoadScene("Sport_watch_AR");
            bTN_SOUND();
        }

    }
    public void bTN_SOUND()
    {
        asource.Stop();
        asource.PlayOneShot(aclip2);
    }


    public void WatchesPages_pagesON()
    {

        Watchpage.GetComponent<WatchesPages>().enabled = true;
    }
}
