using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Buttun : MonoBehaviour
{
    public TextMeshProUGUI zählerText;
    int maxNumber=20;
    int number;
    public Lebensanzeige Lebensanzeige;

    // Start is called before the first frame update
    public void ButtunPressed (){
                number = number -1;
                zählerText.text=number +"";
                Lebensanzeige.SetzeLeben(number);

    }
    void Start()
    {number = maxNumber;
    Lebensanzeige.SetzeMaxLeben(maxNumber);
     

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
