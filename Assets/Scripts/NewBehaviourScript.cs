using HurtadoDiego;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<Lavadora> lavadora = new List<Lavadora>();
        List<Secado> secado = new List<Secado>();


        Lavadora_AddWash lavadora_addwash = new Lavadora_AddWash("3 años", "plastico", "209.90", "LavadoraAddWash:,precio:");
        lavadora.Add(lavadora_addwash);

        Lavadora_MiniWash_3 lavadora_mini = new Lavadora_MiniWash_3("2 años", "metal", "300.99", "LavadoraMiniWash,precio:");
        lavadora.Add(lavadora_mini);

        Secadora_WTG secadora_wtg = new Secadora_WTG("2 años", "metal", "400", "SecadoraWTG,precio:");
        secado.Add(secadora_wtg);

        Plancha_De_Vapor plancha_vapor = new Plancha_De_Vapor("1 año", "metal", "40.50", "Plancha de Vapor,precio:");
        secado.Add(plancha_vapor);

        Plancha_Plegable plancha_plegable = new Plancha_Plegable("6 meses", "metal", "60.68", "Plancha Plegable,precio:");
        secado.Add(plancha_plegable);

        while (true)
        {
            Debug.Log("------------------------------");
            Debug.Log("Lavanderia");
            Debug.Log("Seleccione Categoria");


            Debug.Log("1.Lavadora ");
            Debug.Log("2.Secado");




            string a = System.Console.ReadLine();

            if (a == "1")
            {
                for (int i = 0; i < lavadora.Count; i++)
                {
                    Debug.Log((i + 1) + "" + lavadora[i].nombre + lavadora[i].precio);
                }

            }

            Debug.Log("Presione 2 para ir a secado");

            string d = System.Console.ReadLine();

            if (d == "2")
            {
                for (int i = 0; i < secado.Count; i++)
                {
                    Debug.Log((i + 1) + "" + secado[i].nombre + secado[i].precio);
                }

            }

            Debug.Log("------------------------------");



            string b = System.Console.ReadLine();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
