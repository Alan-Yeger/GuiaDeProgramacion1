//9.Realizá un programa que resuelva el siguiente problema:
//Tres personas aportan diferente capital a una sociedad. Se desea saber qué porcentaje del
//total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado
//por las tres.
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego
//mostrar lo pedido en el siguiente formato:
//Nombre: capital aportado: $ … , Porcentaje del capital: % .... , Monto total aportado: $ ….
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio09 : MonoBehaviour
{
    public string nom1 = "Ingrese el nombre de la primer persona";
    public float num1;
    public string nom2 = "Ingrese el nombre de la segunda persona";
    public float num2;
    public string nom3 = "Ingrese el nombre de la tercer persona";
    public float num3;
    // Start is called before the first frame update
    void Start()
    {
        float total = num1 + num2 + num3;
        float porc1 = num1 * 100 / total;
        float porc2 = num2 * 100 / total;
        float porc3 = num3 * 100 / total;
        Debug.Log(nom1+ ": Capital aportado:$" +num1+ " Porcentaje del capital:%" +porc1);
        Debug.Log(nom2+ ": Capital aportado:$" +num2+ " Porcentaje del capital:%" +porc2);
        Debug.Log(nom3+ ": Capital aportado:$" +num3+ " Porcentaje del capital:%" +porc3);
        Debug.Log("Monto total aportado:$" + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
