using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{       //Variables de cuando fue el ultimo disparo para dar un margen de 1 segundo hasta el proximo disparo
        float lastShoot=0;
        float superPlayerTime= 1f;

        //vidas 
        int lifeMax = 1;
        int lifeNow;
        //Damage, para usar objetos tipo Image tenemos que declarar la libreria: using UnityEngine.UI
        public Image maskDamage;
        //Referenciamos el texto con las vidas
        public TMPro.TextMeshProUGUI textLifes ;

        //Referencia a la pantalla negra
        public Image OutBlack;
        float AlfaValueLast;
    // Start is called before the first frame update
    void Start()
    {   
        //Inicializamos las variables fuera de sus funciones, , debe ir en una funcion que se recargue con frames
        lifeNow=lifeMax;
        textLifes.text = lifeNow.ToString();
        
    }

    //Funcion de Para iniciar el FadeOut
        public void startFadeOut(){
            AlfaValueLast=1;  
    }
    //Funcion de finishFadeOut
    private void finishFadeOut(){
            float alfaValue= Mathf.Lerp(OutBlack.color.a, AlfaValueLast, 0.1f);
        OutBlack.color = new Color(0,0,0 , alfaValue);
        Debug.Log(alfaValue.ToString());
         if (alfaValue>0.99f){
                //Destroy(gameObject);
                SceneManager.LoadScene("Scene1");
            }
        }



    // Update is called once per frame
    void Update()
    {
        
        
    }
     public void getShoot(){
         if (Time.time < Time.time+superPlayerTime){
 
         }
            if(Time.time > lastShoot+superPlayerTime){
                //Reducior vida
                lifeNow -= 1;
                if (lifeNow <= 0 ){
                   // Debug.Log("x_x");
                   startFadeOut();
                   
                //Destroy(gameObject);
                    
                }
                else{
                    lastShoot= Time.time;
                    //Debug.Log("vida actual: "+lifeNow);
                    //Cuando lifeNow== 0, significa que hemos muerto, se desplegara esta imagen
                    maskDamage.color = new Color (1,1,1,0);
                }
                //Se actualiza el contador de vidas
                textLifes.text = lifeNow.ToString();
            }  
    }
        private void FixedUpdate(){
            finishFadeOut();
       
    }


        
}
