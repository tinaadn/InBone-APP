using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MasukObj : MonoBehaviour
{
    public GameObject MateriTulangTangan;
    public GameObject MateriTulangTengkorak;
    public GameObject MateriTulagKaki;
    public GameObject MateriTulangPinggang;
    public GameObject MateriTulangRusuk;
    public GameObject MateriSkeleton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void tangan()
    {
        SceneManager.LoadScene("MateriTangan");
    }

    public void kaki()
    {
        SceneManager.LoadScene("MateriKaki");
    }

    public void pinggang()
    {
        SceneManager.LoadScene("MateriPinggang");
    }
    public void tengkorak()
    {
        SceneManager.LoadScene("MateriKepala");
    }

    public void rusuk()
    {
        SceneManager.LoadScene("MateriRusuk");
    }

    public void skeleton()
    {
        SceneManager.LoadScene("MateriSkeleton");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
