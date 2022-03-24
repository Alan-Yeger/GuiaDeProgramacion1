//8.Crear una variable entera que pueda ser modificada desde el Inspector. Suponiendo que
//el primer día de la semana es el Domingo, mostrar el nombre del día correspondiente al
//valor de la variable “dia”. Si el día no está en el rango permitido debe emitir por pantalla el
//mensaje de error "El día ingresado no es válido".
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio08 : MonoBehaviour
{
    public int dia;
    // Start is called before the first frame update
    void Start()
    {
        if (dia <= 0)
        {
            Debug.Log("El día ingresado no es válido");
        }
        else if (dia %7 == 1)
        {
            Debug.Log("Domingo");
        }
        else if (dia % 7 == 2)
        {
            Debug.Log("Lunes");
        }
        else if (dia % 7 == 3)
        {
            Debug.Log("Martes");
        }
        else if (dia % 7 == 4)
        {
            Debug.Log("Miércoles");
        }
        else if (dia % 7 == 5)
        {
            Debug.Log("Jueves");
        }
        else if (dia % 7 == 6)
        {
            Debug.Log("Viernes");
        }
        else if (dia % 7 == 0)
        {
            Debug.Log("Sábado");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
