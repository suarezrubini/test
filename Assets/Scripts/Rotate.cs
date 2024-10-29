using UnityEngine;

public class Rotate : MonoBehaviour
{

    public Vector3 rotacion = new Vector3(); 

    public float speedRot; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.Rotate(rotacion * speedRot * Time.deltaTime);
    }
}
