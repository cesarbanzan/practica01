using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner2 : MonoBehaviour
{
    public Enemigo2 enemigo2;
    [SerializeField]private float speed=2f;
    private int contarEnemigos = 0;
    private bool crearEnemigos=true;
   // private float timer = 3;
    private bool bajar;
    private float timerRandom;
    // Start is called before the first frame update
    void Start()
    {
        timerRandom = Random.Range(1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        timerRandom -= Time.deltaTime;
     //   timer -= Time.deltaTime;
        if (bajar)
        {
            transform.position -= new Vector3(0f, 0f, speed * Time.deltaTime);   
        }else if(!bajar)
        {
            transform.position += new Vector3(0f, 0f, speed * Time.deltaTime);
        }
        if(transform.position.z < -9.5f)
        {
            bajar = false;
        }else if(transform.position.z > 9.5f) 
        {
            bajar = true;
        }
        if (contarEnemigos<5)
        {
            if (timerRandom < 0 && crearEnemigos==true)
            {
                Instantiate(enemigo2).transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
                contarEnemigos++;
                timerRandom = Random.Range(1, 3);
            }
        }

    }
}
