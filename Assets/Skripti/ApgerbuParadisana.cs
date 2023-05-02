using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApgerbuParadisana : MonoBehaviour {
    public GameObject mainigaisAttels;
    public GameObject izmSlaideris1;
    public GameObject izmSlaideris2;
    public Sprite[] atteluMasivs;

    public void mainitPlatumu()
    {
        float pasreizejaVertiba = izmSlaideris1.GetComponent<Slider>().value;
        float augstums = mainigaisAttels.transform.localScale.y;
        Vector2 newScale = new Vector2(1f * pasreizejaVertiba, augstums);
        mainigaisAttels.transform.localScale = newScale;
    }
    public void mainitAugstumu()
    {
        float pasreizejaVertiba = izmSlaideris2.GetComponent<Slider>().value;
        float platum = mainigaisAttels.transform.localScale.x;
        Vector2 newScale = new Vector2(platum, 1f * pasreizejaVertiba);
        mainigaisAttels.transform.localScale = newScale;
    }
    public void izkritosais(int skaitlis)
    {
        if (skaitlis == 0)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
        else if (skaitlis == 1)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
        else if (skaitlis == 2)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[2];
        else
            Debug.Log("Nav piesaistīts attēls!");
    }
}
