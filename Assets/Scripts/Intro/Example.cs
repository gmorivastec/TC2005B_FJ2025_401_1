using UnityEngine;

public class Example : MonoBehaviour
{

    // lifecycle ???
    // a set of methods that are invoked on specific moments
    // during the execution of a script (component)


    // Awake is invoked first after the creation
    // of the component
    void Awake() 
    {
        print("AWAKE");
    }

    // once all awakes are done we do start
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("START");
    }

    // game engine works in a loop
    // fps ? - frames per second

    // Update is called once per frame
    void Update()
    {
        // 2 THINGS TO ONLY DO HERE:
        // 1 - input
        // 2 - movement
        print("UPDATE");
    }
}
