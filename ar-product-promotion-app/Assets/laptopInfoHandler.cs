using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class laptopInfoHandler : MonoBehaviour
{
    public GameObject InfoChernobyl; 
    public GameObject InfoAlienware18;
    public GameObject InfoZephyrusDuo;
    public string UrlChernobyl = "https://www.google.com/"; 
    public string UrlAlienware18 = "https://www.dell.com/en-us/shop/cty/pdp/spd/alienware-18?sc_err=notincat";
    public string UrlZephyrusDuo = "https://rog.asus.com/laptops/rog-zephyrus/rog-zephyrus-duo-15-series/";
    

    public void InfoChernobylClicked() 
    { 
        InfoChernobyl.SetActive(true);
        InfoAlienware18.SetActive(false);
        InfoZephyrusDuo.SetActive(false);
    }

    public void LinkChernobylClicked()
    {
        Application.OpenURL(UrlChernobyl);
    }

    public void InfoAlienware18Clicked() 
    {
        InfoChernobyl.SetActive(false);
        InfoAlienware18.SetActive(true);
        InfoZephyrusDuo.SetActive(false);
    }

    public void LinkAlienware18Clicked()
    {
        Application.OpenURL(UrlAlienware18);
    }

    public void InfoZephyrusClicked() 
    {
        InfoChernobyl.SetActive(false);
        InfoAlienware18.SetActive(false);
        InfoZephyrusDuo.SetActive(true);
    }

    public void LinkZephyrusDuoClicked()
    {
        Application.OpenURL(UrlZephyrusDuo);
    }

    public void BackInfoClicked() 
    {
        InfoChernobyl.SetActive(false);
        InfoAlienware18.SetActive(false);
        InfoZephyrusDuo.SetActive(false);
    }
}