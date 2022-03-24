//13.Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente
//manera:
//• Si trabaja 40 horas o menos se le paga $16 por hora (crear una constante para almacenar
//el 16)
//• Si trabaja más de 40 horas se le paga $16 por cada una de las primeras 40 horas y $20
//por cada hora extra. (crear una constante para almacenar el 20)
//Ingresar por Inspector la cantidad de horas trabajadas en la semana, y mostrar por pantalla
//el salario correspondiente.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio13 : MonoBehaviour
{
    public int horas;
    // Start is called before the first frame update
    void Start()
    {
        int pago1 = 16;
        int pago2 = 20;
        int pago_semanal;

        if (horas <= 40)
        {
            pago_semanal = horas * 16;
        }
        else
        {
            pago_semanal = 40 * pago1 + (horas - 40) * pago2;
        }
        Debug.Log("Su salario semanal es $" + pago_semanal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
