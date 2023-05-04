using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinasParsledzeja : MonoBehaviour {
	public void uzVaronis1(){
        SceneManager.LoadScene("Varonis1", LoadSceneMode.Single);
    }
    public void Apturet(){
        Application.Quit();
    }
    public void uzVaronis2(){
        SceneManager.LoadScene("Varonis2", LoadSceneMode.Single);
    }
	public void uzSakums(){
        SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
    }
}
