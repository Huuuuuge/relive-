using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechanger : MonoBehaviour
{
    public void plusone()
    { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); }

    public void minusone()
    { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); }

    public void plustwo()
    { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2); }

    public void minustwo()
    { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2); }

    public void plusthree()
    { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3 ); }

    public void minusthree()
    { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3); }

    public void plusfour()
    { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4); }

    public void minusfour()
    { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4); }

    public void jkBack()
    { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5); }

    public void kBack()
    { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6); }

    public void dep()
    { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9); }

    public void depback()
    { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 9); }

    public void sim()
    { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10); }


}
