using UnityEngine;

public class Enemy : MonoBehaviour
{ 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // [SerializeField] private Path currentPath;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Path currentPath;
    private Vector3 _targetPosition;
    private float _relativeDistance = 0f;
    private int _currentWaypointIndex = 0;

    void Awake()
    {
      currentPath = GameObject.Find("Path").GetComponent<Path>();
    }
    // void Start()
    // {
        
    // }

    private void OnEnable()
    {
      
      _targetPosition = currentPath.WaypointsPositions(_currentWaypointIndex);
    }

    // Update is called once per frame
    void Update()
    {
      
        // for (int i = 0; i < (currentPath.Waypoints.Length - 1); i++)
        // {
        //   if (transform.position == currentPath.WaypointsPositions(i))
        //   {
        //     _targetPosition = currentPath.WaypointsPositions(i + 1);
        //   }
        // }

        _relativeDistance = (transform.position - _targetPosition).magnitude;
        if (_relativeDistance < 0.1f)
        {
          if(_currentWaypointIndex < currentPath.Waypoints.Length - 1)
          {
            _currentWaypointIndex++;
            _targetPosition = currentPath.WaypointsPositions(_currentWaypointIndex);
          }
          else
          {
            gameObject.SetActive(false);
          }
        }

        // Move towards the target position with the move speed
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, moveSpeed * Time.deltaTime);
    }
}
