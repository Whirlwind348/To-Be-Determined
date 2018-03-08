using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
 public void OnMouseUp()
 {
  System.Threading.Thread.Sleep(5000);
  SceneManager.LoadScene("Hand Phys");
 }
}