using UnityEngine;

public class Motion : MonoBehaviour
{

    // editor available variables
    // very useful for tweaking the behaviour of a script without editing the code 
    [SerializeField]
    private float _speed = 5;


    // Update is called once per frame
    void Update()
    {
        // polling for input
        // we can poll directly to a device

        // true if key was released last frame but is now pressed
        if(Input.GetKeyDown(KeyCode.O))
        {
            print("KEY DOWN");
        }

        // true if key was pressed last frame and it is still pressed
        if(Input.GetKey(KeyCode.O))
        {
            print("KEY");
        }

        // true if key was pressed last frame but is now released
        if(Input.GetKeyUp(KeyCode.O))
        {
            print("KEY UP");
        }

        // you can also poll the mouse
        if(Input.GetMouseButtonDown(0))
        {
            // do something
        }

        // to avoid inflexibility in the input (polling for a single device)
        // we are using axes

        // axis - abstraction of an input
        // axes - plural of axis not of axe

        // axes can have a value in the range of [-1, 1]

        // if you wish to process the input with no softening use GetAxisRaw
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if(Input.GetButtonDown("Jump"))
            print("jump!");

        // transform (LOWER CASE t)
        // reference to the transform component on the same gameobject

        // since update's frame rate is inconsistent any motion we do must fix this somehow
        // Time.deltaTime - variable that represents how much time has passed from the last frame to the current one
        transform.Translate(
            horizontal * Time.deltaTime * _speed,
            vertical * Time.deltaTime * _speed,
            0,
            Space.World // default - Space.Self
        );

    }


    // COLLISIONS
    // requirements
    // 1. everyone involved has a collider
    // 2. someone has a rigidbody
    // 3. the object with the rigidbody is moving

    void OnCollisionEnter(Collision c)
    {
        // the collision object has information about the collision (obviously)
        // https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Collision.html 

        print("COLLISION ENTER with " + c.transform.name);
        print(c.transform.tag); // string
        print(c.gameObject.layer); // integer


    }

    void OnCollisionStay(Collision c)
    {
        print("COLLISION STAY");
    }

    void OnCollisionExit(Collision c)
    {
        print("COLLISION EXIT");
    }


    void OnTriggerEnter(Collider c)
    {
        print("TRIGGER ENTER");
    }

    void OnTriggerStay(Collider c)
    {
        print("TRIGGER STAY");
    }

    void OnTriggerExit(Collider c)
    {
        print("TRIGGER EXIT");
    }
}
