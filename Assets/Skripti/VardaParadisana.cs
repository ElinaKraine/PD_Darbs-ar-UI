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
	public GameObject kludasTeksts;

    public void UzglabatTekstu() {
		str1 = ievadesLauksVards.GetComponent<InputField>().text;
		int parsedValue;
    	if (!int.TryParse(ievadesLauksVecums.GetComponent<InputField>().text, out parsedValue)) {
        	kludasTeksts.GetComponent<Text>().text = "Nepareizi ievadīts vecums!";
        	return;
    	}
    	str2 = parsedValue;
		tekstaAttelosana.GetComponent<Text>().text = "Spēlētājs spēlē meiteni vārdā " + str1.ToUpper() + ". Lai gan viņa ir dzimusi "+(2023-str2)+".gadā, viņa un viņas māsa kontrolē laiku, viņa dzīvo kopā ar māsu mūzikas kokā.";
		kludasTeksts.GetComponent<Text>().text = "";
	}
}
