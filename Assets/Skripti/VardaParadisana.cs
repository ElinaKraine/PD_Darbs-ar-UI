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
		tekstaAttelosana.GetComponent<Text>().text = "Spēlētājs spēlē jaunu meiteni vārdā " + str1.ToUpper() + ". Viņa ir dzimusi "+(2023-str2)+".gadā un uzaugusi noslēpumainā, maģijas un mistērijas caurvītā salā.";
	}
}
