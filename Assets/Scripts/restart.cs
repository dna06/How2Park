using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class restart : MonoBehaviour {

void Update ()
{
if(Input.GetKeyDown(KeyCode.R))
{
            SceneManager.LoadScene("test");
        }
        if (Input.GetKeyDown(KeyCode.Q))
           {
            Debug.Log("aus"); 
            Application.Quit();

            
        }
    }
}
 