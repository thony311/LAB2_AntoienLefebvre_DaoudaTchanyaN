using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptFin : MonoBehaviour
{
    //Attributs
    private GestionPlayer player;
    private GestionJeu gestionJeu;

    void Start()
    {
        // Va chercher le player et le gestion jeu
        player = FindObjectOfType<GestionPlayer>();
        gestionJeu = FindObjectOfType<GestionJeu>();
    }


    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        // Prend le niveau que le joueur est rendu
        int indexScene = SceneManager.GetActiveScene().buildIndex;
        // Lorsque que le joueur rentre en collision avec l'objet de fin il met fin au jeu
        if(collision.gameObject.tag == "Player")
            if (indexScene == 2)
            {
                // retourne les informations de la fin du jeu et bloque les mouvements du joueur
                float temps = Time.time - player.GetTimeStart();
                int erreurs = gestionJeu.getPointage();
                float total = temps + erreurs - player.GetTimeStart();
                Debug.Log("!!!!!!Fin du jeu!!!!!!!");
                Debug.Log("Vous avez fait le parcour en " + temps);
                Debug.Log("vous avez toucher " + erreurs + " de fois");
                Debug.Log("Le temps finale est maintenant de " + total);
                player.finDeJeu();
            }
            else
            {
                // charger la scene suivante
                SceneManager.LoadScene(indexScene + 1);
            }
    }
}
