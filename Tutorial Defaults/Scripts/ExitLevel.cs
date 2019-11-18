using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour
{
    bool activate = false;

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            activate = true;
        }
        else
        {
            activate = false;
        }
    }

    private void OnTriggerStay2D(Collider2D player)
    {
        if (activate == true)
            SceneManager.LoadScene("Level Select");
    }
}
