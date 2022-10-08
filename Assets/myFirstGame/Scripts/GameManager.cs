
using UnityEngine;
using UnityEngine.SceneManagement;

class GameManager : MonoBehaviour
{
  public void ReStart()
    {
        SceneManager.LoadScene("MyFirstGame");
    }

}
