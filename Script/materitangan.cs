using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class materitangan : MonoBehaviour
{
    public GameObject MateriTulangTangan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //kembali ke menu awal
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
