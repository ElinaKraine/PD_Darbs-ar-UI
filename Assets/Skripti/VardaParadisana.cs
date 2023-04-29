using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour {
	public string str1;
	public int str2;
	public GameObject ievadesLauksVards;
	public GameObject ievadesLauksVecums;
	public GameObject tekstaAttelosana;

	public void UzglabatTekstu() {
		str1 = ievadesLauksVards.GetComponent<InputField>().text;
		str2 = int.Parse(ievadesLauksVecums.GetComponent<InputField>().text);
		tekstaAttelosana.GetComponent<Text>().text = "Vārds: " + str1.ToUpper() + "\nVecums: " + str2;
	}
}
