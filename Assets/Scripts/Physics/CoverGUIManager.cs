using UnityEngine;
using UnityEngine.SceneManagement;

public class CoverGUIManager : MonoBehaviour
{
    public void ChangeScene()
    {
        print("CHANGING SCENE");

        // to change scenes you can use the name or the index
        SceneManager.LoadScene("Physics");
        //SceneManager.LoadScene(1);

    }

    public void Reload()
    {
        print("RELOADING");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Exit()
    {
        print("EXIT");
        Application.Quit();
    }



    /////////////




}
