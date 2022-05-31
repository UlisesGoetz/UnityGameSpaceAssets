using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    //Mandamos a refenciar el objeto player para poder utilizar la funcion dentro del script Manager
    public PlayerManager Player;



    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    //Funcion para colicionar y morir
     void OnTriggerEnter2D(Collider2D other) {
        
        switch(other.gameObject.tag)
        {
            //destruye bala
            case "player":
            //Destroy(Player);
            Player.getShoot();
            break;
            
        }
     }

    // Update is called once per frame
    void Update()
    {
        
    }
}
