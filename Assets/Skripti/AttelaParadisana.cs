using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttelaParadisana : MonoBehaviour {

    public GameObject svarki;
    public GameObject svarkiMainitPlatumu;
    public GameObject svarkiMainitAugstumu;
    public GameObject apavi;
    public GameObject apaviMainitPlatumu;
    public GameObject apaviMainitAugstumu;
    public GameObject krekli;
    public GameObject krekliMainitPlatumu;
    public GameObject krekliMainitAugstumu;
    public GameObject bikses;
    public GameObject biksesMainitPlatumu;
    public GameObject biksesMainitAugstumu;
    public GameObject mati;
    public GameObject matiMainitPlatumu;
    public GameObject matiMainitAugstumu;
    public GameObject kleitas;
    public GameObject kleitasMainitPlatumu;
    public GameObject kleitasMainitAugstumu;

    public void kleitasPar(bool vertiba) {
        kleitas.SetActive(vertiba);
        kleitasMainitAugstumu.SetActive(vertiba);
        kleitasMainitPlatumu.SetActive(vertiba);
    }
    public void svarkiPar(bool vertiba) {
        svarki.SetActive(vertiba);
        svarkiMainitAugstumu.SetActive(vertiba);
        svarkiMainitPlatumu.SetActive(vertiba);
    }
	public void krekliPar(bool vertiba) {
        krekli.SetActive(vertiba);
        krekliMainitAugstumu.SetActive(vertiba);
        krekliMainitPlatumu.SetActive(vertiba);
    }
	public void biksesPar(bool vertiba) {
        bikses.SetActive(vertiba);
        biksesMainitAugstumu.SetActive(vertiba);
        biksesMainitPlatumu.SetActive(vertiba);
    }
	public void apaviPar(bool vertiba) {
        apavi.SetActive(vertiba);
        apaviMainitAugstumu.SetActive(vertiba);
        apaviMainitPlatumu.SetActive(vertiba);
    }
	public void matiPar(bool vertiba) {
        mati.SetActive(vertiba);
        matiMainitAugstumu.SetActive(vertiba);
        matiMainitPlatumu.SetActive(vertiba);
    }


}






