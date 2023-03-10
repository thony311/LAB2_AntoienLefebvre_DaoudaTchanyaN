using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptFin : MonoBehaviour
{
    //Attribut
    private GestionPlayer player;
    private GestionJeu gestionJeu;

    void Start()
    {
        player = FindObjectOfType<GestionPlayer>();
        gestionJeu = FindObjectOfType<GestionJeu>();
    }


    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        int indexScene = SceneManager.GetActiveScene().buildIndex;


        if (collision.gameObject.tag == "Player" )
        {
            float temps = Time.time - player.GetTimeStart();
            int erreurs = gestionJeu.getPointage();
            float total = temps + erreurs - player.GetTimeStart();
            Debug.Log("!!!!!!Fin du jeu!!!!!!!");
            Debug.Log("Vous avez fait le parcour en " + temps);
            Debug.Log("vous avez toucher " + erreurs + " de fois");
            Debug.Log("Le temps finale est maintenant de " + total);
            player.finDeJeu();
        }
        //else
        //{
        //    // charger la scene suivante
        //    SceneManager.LoadScene(indexScene + 1);
        //}
    }
}
