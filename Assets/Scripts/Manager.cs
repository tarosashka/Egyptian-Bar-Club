using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public GameObject[] panels;
    public GameObject[] tablebttns;
    public GameObject nextbttn1;
    public Text tabletext;
    int tableno;
    public AudioSource bttnsound;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void panel2(bool value)
    {
        panels[1].SetActive(value);
        bttnsound.Play();
    }
    public void panel3(bool value)
    {
        bttnsound.Play();

        panels[2].SetActive(value);
        for (int i = 0; i < 6; i++)
        {
            tablebttns[i].SetActive(true);
        }
    }
    public void selecttables(int no)
    {
        bttnsound.Play();

        for (int i = 0; i < 6; i++)
        {
            tablebttns[i].SetActive(false);
        }
        tablebttns[no].SetActive(true);
        nextbttn1.SetActive(true);
        tableno = no;
    }
    public void wheelround(bool value)
    {
        bttnsound.Play();

        panels[4].SetActive(value);
    }
    public void panel4(bool value)
    {
        bttnsound.Play();

        panels[3].SetActive(value);
        tabletext.text = "Table no: " + ++tableno;
    }
}
