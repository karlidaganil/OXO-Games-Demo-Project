using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject butonum;
    public GameObject panel;
    public GameObject[] liseButonlari;
    static int counter = 0;
    public InputField inputalani;
    public Text matchCounttext;
    List<int> benimListem;

    int[] listem;
    int xPOS = 0;
    int yPOS = 0;

    public int kacli = 3;

    int asaIn;

    int kutuKoyduk;

    public Sprite carpiSpriteim;
    public Sprite duzBeyazSpriteim;

    int tikCount = 0;
    int matchCount = 0;

    void Awake()
    {

        liseButonlari = new GameObject[50];
        listem = new int[50];
        asaIn = kacli;

        //kacli = kacli * kacli;



        // asaIn = int.Parse(inputField.text);

        kacli = asaIn * asaIn;

        inputalani.text = "3";
        

    }
    void Start()
    {
        Debug.Log(Screen.width+" "+ Screen.height);
        benimListem = new List<int>();
        matchCounttext.text = "MATCH Count:" + matchCount;
        build();
    }


    void Update()
    {



    }



    public void rebuild()
    {
      

        for (int i = 1; i < liseButonlari.Length; i++)
        {
            Destroy(liseButonlari[i]);

            xPOS = 0;
            yPOS = 0;

        }



         int x = System.Int32.Parse(inputalani.text);
       

        kacli = x * x;
        asaIn = x;

        for (int i = 1; i <= kacli; i++)
        {
            liseButonlari[i] = Instantiate(butonum, new Vector3((100) + xPOS, (400) + yPOS, 0), Quaternion.identity);
            liseButonlari[i].transform.SetParent(panel.transform);
            xPOS = xPOS + 55;

            if (i % asaIn == 0)
            {
                yPOS = yPOS - 50;
                xPOS = 0;
            }

            if (i == kacli)
            {
                yPOS = 0;
            }

        }


    }
    public void xxx()
    {



        benimListem.Sort();
        for (int i = 0; i < benimListem.Count; i++)
        {
            Debug.Log(benimListem[i]);
        }
    }


    public void say()
    {

        

        for (int i = 1; i <= (System.Int32.Parse(inputalani.text) * System.Int32.Parse(inputalani.text)); i++)
        {

            if (liseButonlari[i].GetComponent<Image>().sprite == carpiSpriteim)
            {
                // listem[i] = i;



                if (benimListem.Contains(i) == false)
                {
                    benimListem.Add(i);
                    tikCount++;
                }

            }

        }

        benimListem.Sort();
    }


    public void ListeYazdir()
    {
        int kac = System.Int32.Parse(inputalani.text);


        if (tikCount == 4)
        {
            for (int i = 0; i < 36; i++)
            {
                if (i % kac != 0)
                {
                    if (benimListem.Contains(i) && benimListem.Contains(i + 1))
                    {

                        counter++;
                    }
                }
                if (benimListem.Contains(i) && benimListem.Contains(i + kac))
                {
                    counter++;
                }
            }
        }


        if(counter>=3)
        {
            Debug.Log("GAME");
            matchCount++;
            matchCounttext.text = "MATCH Count:" + matchCount;
            for (int i = 1; i <= (System.Int32.Parse(inputalani.text) * System.Int32.Parse(inputalani.text)); i++)
            {

                if (liseButonlari[i].GetComponent<Image>().sprite == carpiSpriteim)
                {
                    liseButonlari[i].GetComponent<Image>().sprite = duzBeyazSpriteim;
                }

            }
            benimListem.Clear();
            tikCount = 0;
            counter = 0;
        }
    }

    void build()
    {
        for (int i = 1; i < liseButonlari.Length; i++)
        {
            Destroy(liseButonlari[i]);

            xPOS = 0;
            yPOS = 0;

        }



        // int x = System.Int32.Parse(inputalani.text);

        int x;
        if(inputalani.text=="")
        {
            x = 5;
        }
        else
        {
            x= System.Int32.Parse(inputalani.text);
        }


        kacli = x * x;
        asaIn = x;

        for (int i = 1; i <= kacli; i++)
        {
            liseButonlari[i] = Instantiate(butonum, new Vector3((100) + xPOS, (400) + yPOS, 0), Quaternion.identity);
            liseButonlari[i].transform.SetParent(panel.transform);
            xPOS = xPOS + 55;

            if (i % asaIn == 0)
            {
                yPOS = yPOS - 50;
                xPOS = 0;
            }

            if (i == kacli)
            {
                yPOS = 0;
            }

        }
    }

  









}






