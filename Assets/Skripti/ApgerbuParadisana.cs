using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApgerbuParadisana : MonoBehaviour {
    public GameObject mainigaisAttels1;
    public GameObject izmSlaideris11;
    public GameObject izmSlaideris21;
    public Sprite[] atteluMasivs1;

    public GameObject mainigaisAttels2;
    public GameObject izmSlaideris12;
    public GameObject izmSlaideris22;
    public Sprite[] atteluMasivs2;

    public GameObject mainigaisAttels3;
    public GameObject izmSlaideris13;
    public GameObject izmSlaideris23;
    public Sprite[] atteluMasivs3;

    public GameObject mainigaisAttels4;
    public GameObject izmSlaideris14;
    public GameObject izmSlaideris24;
    public Sprite[] atteluMasivs4;

    public GameObject mainigaisAttels5;
    public GameObject izmSlaideris15;
    public GameObject izmSlaideris25;
    public Sprite[] atteluMasivs5;

    public GameObject mainigaisAttels6;
    public GameObject izmSlaideris16;
    public GameObject izmSlaideris26;
    public Sprite[] atteluMasivs6;

    public void mainitPlatumuKleitas()
    {
        float pasreizejaVertiba = izmSlaideris11.GetComponent<Slider>().value;
        float augstums = mainigaisAttels1.transform.localScale.y;
        Vector2 newScale = new Vector2(1f * pasreizejaVertiba, augstums);
        mainigaisAttels1.transform.localScale = newScale;
    }
    public void mainitAugstumuKleitas()
    {
        float pasreizejaVertiba = izmSlaideris21.GetComponent<Slider>().value;
        float platum = mainigaisAttels1.transform.localScale.x;
        Vector2 newScale = new Vector2(platum, 1f * pasreizejaVertiba);
        mainigaisAttels1.transform.localScale = newScale;
    }
    public void izkritosaisKleitas(int skaitlis)
    {
        if (skaitlis == 0)
            mainigaisAttels1.GetComponent<Image>().sprite = atteluMasivs1[0];
        else if (skaitlis == 1)
            mainigaisAttels1.GetComponent<Image>().sprite = atteluMasivs1[1];
        else if (skaitlis == 2)
            mainigaisAttels1.GetComponent<Image>().sprite = atteluMasivs1[2];
        else
            Debug.Log("Nav piesaistīts attēls!");
    }

    public void mainitPlatumuKrekli()
    {
        float pasreizejaVertiba = izmSlaideris12.GetComponent<Slider>().value;
        float augstums = mainigaisAttels2.transform.localScale.y;
        Vector2 newScale = new Vector2(1f * pasreizejaVertiba, augstums);
        mainigaisAttels2.transform.localScale = newScale;
    }
    public void mainitAugstumuKrekli()
    {
        float pasreizejaVertiba = izmSlaideris22.GetComponent<Slider>().value;
        float platum = mainigaisAttels2.transform.localScale.x;
        Vector2 newScale = new Vector2(platum, 1f * pasreizejaVertiba);
        mainigaisAttels2.transform.localScale = newScale;
    }
    public void izkritosaisKrekli(int skaitlis)
    {
        if (skaitlis == 0)
            mainigaisAttels2.GetComponent<Image>().sprite = atteluMasivs2[0];
        else if (skaitlis == 1)
            mainigaisAttels2.GetComponent<Image>().sprite = atteluMasivs2[1];
        else if (skaitlis == 2)
            mainigaisAttels2.GetComponent<Image>().sprite = atteluMasivs2[2];
        else
            Debug.Log("Nav piesaistīts attēls!");
    }

    public void mainitPlatumuSvarki()
    {
        float pasreizejaVertiba = izmSlaideris13.GetComponent<Slider>().value;
        float augstums = mainigaisAttels3.transform.localScale.y;
        Vector2 newScale = new Vector2(1f * pasreizejaVertiba, augstums);
        mainigaisAttels3.transform.localScale = newScale;
    }
    public void mainitAugstumuSvarki()
    {
        float pasreizejaVertiba = izmSlaideris23.GetComponent<Slider>().value;
        float platum = mainigaisAttels3.transform.localScale.x;
        Vector2 newScale = new Vector2(platum, 1f * pasreizejaVertiba);
        mainigaisAttels3.transform.localScale = newScale;
    }
    public void izkritosaisSvarki(int skaitlis)
    {
        if (skaitlis == 0)
            mainigaisAttels3.GetComponent<Image>().sprite = atteluMasivs3[0];
        else if (skaitlis == 1)
            mainigaisAttels3.GetComponent<Image>().sprite = atteluMasivs3[1];
        else if (skaitlis == 2)
            mainigaisAttels3.GetComponent<Image>().sprite = atteluMasivs3[2];
        else
            Debug.Log("Nav piesaistīts attēls!");
    }

    public void mainitPlatumuMati()
    {
        float pasreizejaVertiba = izmSlaideris14.GetComponent<Slider>().value;
        float augstums = mainigaisAttels4.transform.localScale.y;
        Vector2 newScale = new Vector2(1f * pasreizejaVertiba, augstums);
        mainigaisAttels4.transform.localScale = newScale;
    }
    public void mainitAugstumuMati()
    {
        float pasreizejaVertiba = izmSlaideris24.GetComponent<Slider>().value;
        float platum = mainigaisAttels4.transform.localScale.x;
        Vector2 newScale = new Vector2(platum, 1f * pasreizejaVertiba);
        mainigaisAttels4.transform.localScale = newScale;
    }
    public void izkritosaisMati(int skaitlis)
    {
        if (skaitlis == 0)
            mainigaisAttels4.GetComponent<Image>().sprite = atteluMasivs4[0];
        else if (skaitlis == 1)
            mainigaisAttels4.GetComponent<Image>().sprite = atteluMasivs4[1];
        else if (skaitlis == 2)
            mainigaisAttels4.GetComponent<Image>().sprite = atteluMasivs4[2];
        else
            Debug.Log("Nav piesaistīts attēls!");
    }

    public void mainitPlatumuBikses()
    {
        float pasreizejaVertiba = izmSlaideris15.GetComponent<Slider>().value;
        float augstums = mainigaisAttels5.transform.localScale.y;
        Vector2 newScale = new Vector2(1f * pasreizejaVertiba, augstums);
        mainigaisAttels5.transform.localScale = newScale;
    }
    public void mainitAugstumuBikses()
    {
        float pasreizejaVertiba = izmSlaideris25.GetComponent<Slider>().value;
        float platum = mainigaisAttels5.transform.localScale.x;
        Vector2 newScale = new Vector2(platum, 1f * pasreizejaVertiba);
        mainigaisAttels5.transform.localScale = newScale;
    }
    public void izkritosaisBikses(int skaitlis)
    {
        if (skaitlis == 0)
            mainigaisAttels5.GetComponent<Image>().sprite = atteluMasivs5[0];
        else if (skaitlis == 1)
            mainigaisAttels5.GetComponent<Image>().sprite = atteluMasivs5[1];
        else if (skaitlis == 2)
            mainigaisAttels5.GetComponent<Image>().sprite = atteluMasivs5[2];
        else
            Debug.Log("Nav piesaistīts attēls!");
    }

    public void mainitPlatumuApavi()
    {
        float pasreizejaVertiba = izmSlaideris16.GetComponent<Slider>().value;
        float augstums = mainigaisAttels6.transform.localScale.y;
        Vector2 newScale = new Vector2(1f * pasreizejaVertiba, augstums);
        mainigaisAttels6.transform.localScale = newScale;
    }
    public void mainitAugstumuApavi()
    {
        float pasreizejaVertiba = izmSlaideris26.GetComponent<Slider>().value;
        float platum = mainigaisAttels6.transform.localScale.x;
        Vector2 newScale = new Vector2(platum, 1f * pasreizejaVertiba);
        mainigaisAttels6.transform.localScale = newScale;
    }
    public void izkritosaisApavi(int skaitlis)
    {
        if (skaitlis == 0)
            mainigaisAttels6.GetComponent<Image>().sprite = atteluMasivs6[0];
        else if (skaitlis == 1)
            mainigaisAttels6.GetComponent<Image>().sprite = atteluMasivs6[1];
        else if (skaitlis == 2)
            mainigaisAttels6.GetComponent<Image>().sprite = atteluMasivs6[2];
        else
            Debug.Log("Nav piesaistīts attēls!");
    }
}
