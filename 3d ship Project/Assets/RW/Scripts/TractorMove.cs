using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum TractorState { Move, Stop };






public class TractorMove : MonoBehaviour
{
    [SerializeField] private float speed;
    private float direction;
    // private bool mooving;
    [SerializeField] private GameObject seno;
    [SerializeField] private float fireRate;
    private float nextFire;
    private Transform spawnPoiont;
    [SerializeField]private Transform senoManager;


    private TractorState tractorState = TractorState.Stop;

    private void Awake()
    {
        spawnPoiont = transform.GetChild(1);
       // senoManager = transform.GetChild(4);
    }




    void Update()
    {

        MoveTractor();
        nextFire -= Time.deltaTime;
    }



    public void MoveRight()
    {
        
        direction = 1f;
        //mooving = true;
        tractorState = TractorState.Move;
    }
    public void MoveLeft()
    {
        
        direction = -1f;
        // mooving = true;
        tractorState = TractorState.Move;
    }
    public void StopMove()
    {

        //direction = 0f;
        //mooving = false;
        tractorState = TractorState.Stop;
    }
    public void Fire()
    {
        if(nextFire < 0)
        {

        
       GameObject seno = Instantiate(this.seno, spawnPoiont.position, this.seno.transform.rotation);
        seno.transform.SetParent(senoManager);
        Destroy(seno, 10f);
            nextFire = fireRate;
        }
    }
    private void MoveTractor()
    {
        if (tractorState == TractorState.Move)
        {
            if (((transform.position.x >= -22f) && (direction == -1f)) || ((transform.position.x <= 22f) && (direction == 1f)))

            {
                transform.Translate(Vector3.right * speed * direction * Time.deltaTime);
            }
        }

    }
}
