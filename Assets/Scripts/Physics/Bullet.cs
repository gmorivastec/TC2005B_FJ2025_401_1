using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    // i need a reference to the rigidbody in order to be able to use it
    private Rigidbody _rigidbody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        // get a reference to another component
        _rigidbody = GetComponent<Rigidbody>();

        // addforce uses world scope
        // 3 helpful vector
        // transform.up
        // transform.forward
        // transform.right

        // ALL of them on world space
        // ALL of them are normalized
        
        _rigidbody.AddForce(
            transform.up * 10,
            ForceMode.Impulse
        );

        // whenever we create objects on runtime we need clean-up strategies
        Destroy(gameObject, 4); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }


    
}
