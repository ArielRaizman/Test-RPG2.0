using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetAxisRaw("Horizontal") > 0.25f || Input.GetAxisRaw("Horizontal") < -0.25f)  
         {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime,0.0f,0.0f));
            if (moveSpeed > 0.25f) 
            {
                anim.SetBool("PrevRight",true);
            }
            else if (moveSpeed < -0.5f) 
            {
                anim.SetBool("PrevRight",false);
            }
            else 
            {
                return;
            }
                
         }
        if (Input.GetAxisRaw("Vertical") > 0.25f || Input.GetAxisRaw("Vertical") < -0.25f)
        {
            transform.Translate(new Vector3(0.0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0.0f));
        }

        anim.SetFloat("MoveX",Input.GetAxisRaw("Horizontal"));
    }




}





