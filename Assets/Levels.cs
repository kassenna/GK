using System.Linq;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vector3 = UnityEngine.Vector3;
// Adam Hudziak
public class Levels : MonoBehaviour
{
  
public void click(string name)
{
    Time.timeScale = 1;
SceneManager.LoadScene(name);

}
   

  
}
