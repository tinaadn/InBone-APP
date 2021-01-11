using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MulaiMenu : MonoBehaviour
{
    public GameObject MenuStart;
    public GameObject Help;
    // Start is called before the first frame update
    void Start()
    {
        MenuStart.SetActive(true);
    }

    //Start Ke Obj
    public void button_start()
    {
        SceneManager.LoadScene("SkeletonUtuh");
    }

    public void Link()
    {
        Application.OpenURL("http://bit.ly/PostCardInBone");
    }

    public void ButtonHelp()
    {
        MenuStart.SetActive(false);
        Help.SetActive(true);
    }

    public void Back()
    {
        MenuStart.SetActive(true);
        Help.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
