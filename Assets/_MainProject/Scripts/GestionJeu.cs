using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionJeu : MonoBehaviour
{
    // attribut
    private int _pointage;

    private void Awake()
    {
        int nbGestionJeu = FindObjectsOfType<GestionJeu>().Length;
        if (nbGestionJeu > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        _pointage = 0;
        Instructions();

    }

    private static void Instructions()
    {
        Debug.Log("*** Course à obstacles ***");
        Debug.Log("Atteinfre la fin du parcours le plus rapidement possible");
    }

    // méthode publique
    public void AugmenterPointage()
    {
        _pointage++;
        Debug.Log("Nombre d'accrochage :" + _pointage);
    }

    public int getPointage()
    {
        return _pointage;
    }
}
