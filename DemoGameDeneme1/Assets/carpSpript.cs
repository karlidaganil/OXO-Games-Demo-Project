using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carpSpript : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject butonum;
    public Sprite CarpiSprite;
    public Sprite beyazSprite;

    GameObject gameController;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void CarpiYap()
    {
        if(butonum.GetComponent<Image>().sprite != CarpiSprite)
        {
            butonum.GetComponent<Image>().sprite = CarpiSprite;
            GameObject.FindGameObjectWithTag("game").GetComponent<GameController>().say();
            GameObject.FindGameObjectWithTag("game").GetComponent<GameController>().ListeYazdir();
        }
        else
        {
            butonum.GetComponent<Image>().sprite = beyazSprite;

        }



       
    }
}
