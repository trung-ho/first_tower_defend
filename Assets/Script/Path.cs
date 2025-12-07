using UnityEngine;
using UnityEditor;

public class Path : MonoBehaviour
{
  // Start is called once before the first execution of Update after the MonoBehaviour is created
  public GameObject[] Waypoints;



  // void Start()
  // {
  //   // Hello World!
  // }

  // // Update is called once per frame
  // void Update()
  // {

  // }

  private void OnDrawGizmos()
  { 
    if (Waypoints.Length > 0)
    {
      for (int i = 0; i < Waypoints.Length; i++)
      {
        GUIStyle style = new GUIStyle();
        style.normal.textColor = Color.white;
        style.fontStyle = FontStyle.Bold;
        style.alignment = TextAnchor.MiddleCenter;
        Handles.Label(Waypoints[i].transform.position + Vector3.up * 0.5f + Vector3.left * 0.5f, Waypoints[i].name.ToString(), style);
        
        if (i < Waypoints.Length -1)
        {
          Gizmos.color = Color.gray;
          Gizmos.DrawLine(Waypoints[i].transform.position, Waypoints[i + 1].transform.position);
        }
      }
    }
  }
}

