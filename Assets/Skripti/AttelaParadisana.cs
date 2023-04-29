using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttelaParadisana : MonoBehaviour {

    public GameObject kleita1;
	public GameObject kleita2;
	public GameObject kleita3;

	public GameObject s1;
	public GameObject s2;
	public GameObject s3;

	public GameObject b1;
	public GameObject b2;
	public GameObject b3;

	public GameObject k1;
	public GameObject k2;
	public GameObject k3;

	public GameObject apavi1;
	public GameObject apavi2;
	public GameObject apavi3;

	public GameObject mati1;
	public GameObject mati2;
	public GameObject mati3;

	public void kleitas(bool vertiba) {
        kleita1.SetActive(vertiba);
		kleita2.SetActive(vertiba);
		kleita3.SetActive(vertiba);
    }
    public void svarki(bool vertiba) {
        s1.SetActive(vertiba);
		s2.SetActive(vertiba);
		s3.SetActive(vertiba);
    }
	public void krekli(bool vertiba) {
        k1.SetActive(vertiba);
		k2.SetActive(vertiba);
		k3.SetActive(vertiba);
    }
	public void bikses(bool vertiba) {
        b1.SetActive(vertiba);
		b2.SetActive(vertiba);
		b3.SetActive(vertiba);
    }
	public void apavi(bool vertiba) {
        apavi1.SetActive(vertiba);
		apavi2.SetActive(vertiba);
		apavi3.SetActive(vertiba);
    }
	public void mati(bool vertiba) {
        mati1.SetActive(vertiba);
		mati2.SetActive(vertiba);
		mati3.SetActive(vertiba);
    }


}






