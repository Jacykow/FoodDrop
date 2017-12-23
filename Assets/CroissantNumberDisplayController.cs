using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Uwaga nowy import, bo Text 

public class CroissantNumberDisplayController : MonoBehaviour
{
    //Do zakodzenia cała klasa z zawartym pomocniczym updatem :)

    private void Update()
    {
        string t = "" + 68; //taka sztuczka ze stringami
        gameObject.GetComponent<Text>().text = t;
    }
}