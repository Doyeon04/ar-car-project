using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileT : MonoBehaviour
{
    public GameObject car1; // Marcedes-Benz GLE
    public GameObject car2; // Mercedes Benz S500
    public GameObject car3; // Merce-Benz_E63
  
    private int num;
    public GameObject car1Title;
    public GameObject car2Title;
    public GameObject car3Title;


    
    void Start()
    {


      
        num = 0;
     
        car1Title.SetActive(true);
        car2Title.SetActive(false);
        car3Title.SetActive(false);

    }


    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Å¬¸¯");
            Debug.Log("num:" + num);
            num++;
            if (num == 0)
            {
                car1.SetActive(true);
                car2.SetActive(false);
                car3.SetActive(false);

                car1Title.SetActive(true);
                car2Title.SetActive(false);
                car3Title.SetActive(false);
                
            }
            else if (num == 1)
            {
                car1.SetActive(false);
                car2.SetActive(true);
                car3.SetActive(false);

                car1Title.SetActive(false);
                car2Title.SetActive(true);
                car3Title.SetActive(false);
                
            }
            else if (num == 2)
            {
                car1.SetActive(false);
                car2.SetActive(false);
                car3.SetActive(true);

                car1Title.SetActive(false);
                car2Title.SetActive(false);
                car3Title.SetActive(true);
               
            }
            else if(num == 3)
            {
                num = 0;
                car1.SetActive(true);
                car2.SetActive(false);
                car3.SetActive(false);

                car1Title.SetActive(true);
                car2Title.SetActive(false);
                car3Title.SetActive(false);
            }


        }
    }
}
