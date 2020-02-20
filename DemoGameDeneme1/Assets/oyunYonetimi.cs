using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oyunYonetimi : MonoBehaviour
{


   // public Canvas myCanvas;

    public GameObject butonum;

    public  int kac=3;

    GameObject [] Butonlarim;

    Vector3 canvasPos;

    public GameObject [] buttonVerticalContainer;

    int butonCounter = 0;


    //public Sprite CarpiSprite;


    void Awake()
    {
        
        Butonlarim = new GameObject[kac * kac];
        
        //for(int i=0;i<Butonlarim.Length;i++)
        //{
        //    Debug.Log(Butonlarim[i].GetInstanceID());   
        //}

      //  canvasPos = new Vector3(myCanvas.transform.position.x, myCanvas.transform.position.y, myCanvas.transform.position.z);
    }


    void Start()
    {

        //for (int i=0; i<(3*3);i++)
        //{
        //    Butonlarim[i] = Instantiate(butonum, new Vector3(), Quaternion.identity);
        //    Butonlarim[i].transform.SetParent(myCanvas.transform);
        //}

        //for (int i=0; i< kac; i++)
        //{
        //    Butonlarim[i] = Instantiate(butonum, new Vector3(), Quaternion.identity);
        //    Butonlarim[i].transform.SetParent(buttonVerticalContainer[i].transform);

        //    for (int y=0;y< kac; y++)
        //    {
        //        Butonlarim[y+1] = Instantiate(butonum, new Vector3(), Quaternion.identity);
        //        Butonlarim[y].transform.SetParent(buttonVerticalContainer[y].transform);
        //    }
        //}

        for (int i = butonCounter; i < 3; i++)
        {
            Butonlarim[i] = Instantiate(butonum, new Vector3(), Quaternion.identity);
            Butonlarim[i].transform.SetParent(buttonVerticalContainer[0].transform);
            butonCounter++;
        }
        for (int i = 0; i < 3; i++)
        {
            Butonlarim[butonCounter] = Instantiate(butonum, new Vector3(), Quaternion.identity);
            Butonlarim[butonCounter].transform.SetParent(buttonVerticalContainer[1].transform);
            butonCounter++;
        }
        for (int i = 0; i < 3; i++)
        {
            Butonlarim[butonCounter] = Instantiate(butonum, new Vector3(), Quaternion.identity);
            Butonlarim[butonCounter].transform.SetParent(buttonVerticalContainer[2].transform);
            butonCounter++;
        }



    }

    
    

   




}


