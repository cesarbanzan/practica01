using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    public Bala Bala;
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        float movementX = Input.GetAxis("Horizontal");
        Vector3 movementDirections= new Vector3 (movementX, 0f, 0f);

        transform.position+= movementDirections* speed*Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(Bala).transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        }
    }

  
}
