using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;

    /*public Vector3 x;
    public Vector3 y; 
    public Vector3 z;*/ 

    private Vector3 initPos;
    [SerializeField] Vector3 destPos;
    private Vector3 finalPos;

    public Vector3 movimiento; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //SUMA DE VECTORES 

        initPos = transform.position;
        finalPos = initPos + destPos * Time.deltaTime * speed; 
        transform.position = finalPos;


        //MOVIMIENTO 
        
        transform.Translate(movimiento * Time.deltaTime * speed); 

    }
}
