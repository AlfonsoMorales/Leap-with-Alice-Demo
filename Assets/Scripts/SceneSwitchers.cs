﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneSwitchers : MonoBehaviour {

    public void SwitchtoAlice()
    {
        SceneManager.LoadScene("alice Lens");
    }

    public void SwitchtoHillel()
    {
        SceneManager.LoadScene("Hillel");
    }

    public void SwitchtoSaltofHeaven()
    {
        SceneManager.LoadScene("SaltofHeaven");
    }

    public void SwitchtoPaving()
    {
        SceneManager.LoadScene("PavingtheWay");
    }

    public void SwitchtoMontessori()
    {
        SceneManager.LoadScene("Montessori");
    }

    public void SwitchtoUCF()
    {
        SceneManager.LoadScene("UCF");
    }

    public void SwitchtoPolyBlox()
    {
        SceneManager.LoadScene("PolyBlox");
    }
}
