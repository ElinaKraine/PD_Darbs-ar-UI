using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinasParsledzeja : MonoBehaviour {
	public void uzScene(){
        SceneManager.LoadScene("Scene", LoadSceneMode.Single);
    }
    public void Apturet(){
        Application.Quit();
    }
    public void uzScene2(){
        SceneManager.LoadScene("Scene2", LoadSceneMode.Single);
    }
	public void uzSakums(){
        SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
    }
}
