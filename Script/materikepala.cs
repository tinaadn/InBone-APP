using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class materikepala : MonoBehaviour
{
    public GameObject MateriTulangTengkorak;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Button_Back()
    {
        SceneManager.LoadScene("SkeletonUtuh");
    }

    public void Buttonhome()
    {
        SceneManager.LoadScene("StartScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
