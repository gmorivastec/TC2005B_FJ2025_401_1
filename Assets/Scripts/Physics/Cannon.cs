using System.Collections;
using NUnit.Framework;
using UnityEngine;

public class Cannon : MonoBehaviour
{

    [SerializeField]
    private float _speed = 5;

    [SerializeField]
    private GameObject _original;

    [SerializeField]
    private GameObject _reference;

    private IEnumerator _enumeratorCoroutine, _enumeratorDisparo;
    private Coroutine _coroutine;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Assert.IsNotNull(_original, "ORIGINAL CANT BE NULL ON CANNON");
        Assert.IsNotNull(_reference, "REFERENCE CANT BE NULL ON CANNON");

        //StartCoroutine("LinealCoroutine");
        //StartCoroutine(LinealCoroutine());
        
        //StartCoroutine("LoopCoroutine");
        //StartCoroutine(LoopCoroutine());

        _enumeratorCoroutine = LoopCoroutine();
        _enumeratorDisparo = Disparo();
        // _coroutine = StartCoroutine(_enumeratorCoroutine);


    }

    // Update is called once per frame
    void Update()
    {
        // move
        float horizontal = Input.GetAxis("Horizontal");

        transform.Translate(
            0,
            0,
            horizontal * _speed * Time.deltaTime
        );

        // shoot

        if(Input.GetButtonDown("Jump"))
        {
            StartCoroutine(_enumeratorDisparo);
        }

        if(Input.GetButtonUp("Jump"))
        {
            StopCoroutine(_enumeratorDisparo);
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            StopAllCoroutines();
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            //StopCoroutine("LoopCoroutine");
            //StopCoroutine(_enumeratorCoroutine);
            StopCoroutine(_coroutine);
        }

        if(Input.GetKeyDown(KeyCode.Z))
        {

            ManagerEjemplo.Instancia.DecirHola();
            print("puntaje: " + ManagerEjemplo.Instancia.Puntaje);
            
            // alternativa
            // GameObject.Find();
            
            // this will fail
            // ManagerEjemplo.Instancia.Puntaje = 5;
        }




    }

    // COROUTINES
    // pseudoconcurrent code
    // 2 main uses:
    // 1. linear code in which we don't know duration time
    // 2. parallel loops 

    // MORE ABOUT COROUTINES
    // coroutines are owned by the component
    // they can be stopped intentionally
    // when the component is destroyed coroutines stop also

    IEnumerator LinealCoroutine()
    {
        yield return new WaitForSeconds(3);
        print("LINEAL COROUTINE");
    }

    IEnumerator LoopCoroutine()
    {
        while(true)
        {
            print("LOOP COROUTINE");
            yield return new WaitForSeconds(1);
        }
    }

    IEnumerator Disparo()
    {
        while(true)
        {
            // new stuff
            Instantiate(
                _original,
                _reference.transform.position,
                _reference.transform.rotation    
            );
            yield return new WaitForSeconds(0.5f);
        }
    }
}
