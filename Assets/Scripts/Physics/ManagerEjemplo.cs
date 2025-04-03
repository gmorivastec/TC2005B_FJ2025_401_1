using UnityEngine;

public class ManagerEjemplo : MonoBehaviour
{
    // https://en.wikipedia.org/wiki/Singleton_pattern

    // properties in C# 
    // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties
    public static ManagerEjemplo Instancia
    {
        get;
        private set;
    }

    [SerializeField]
    private int _puntaje = 1;

    public int Puntaje
    {
        get {
            return _puntaje;
        }
        private set {
            _puntaje = value;
        }
    }



    void Awake()
    {
        // corrective singleton
        if(Instancia == null)
            Instancia = this;
        else
            Destroy(gameObject);
    }

    public void DecirHola()
    {
        print("HOLA DESDE EL MANAGER!");
    }
}
