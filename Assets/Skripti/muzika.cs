using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muzika : MonoBehaviour {
	public AudioSource skanasAvots;
    public AudioClip skanaKoAtskanot;
	public AudioSource skanasAvots1;
    public AudioClip skanaKoAtskanot1;
    
    public void uzbiditsUzAttela(){
        skanasAvots.PlayOneShot(skanaKoAtskanot);
    }
    public void kursorsNost(){
        skanasAvots.Stop();
    }

	public void uzbiditsUzAttela1(){
        skanasAvots1.PlayOneShot(skanaKoAtskanot1);
    }
    public void kursorsNost1(){
        skanasAvots1.Stop();
    }
}
