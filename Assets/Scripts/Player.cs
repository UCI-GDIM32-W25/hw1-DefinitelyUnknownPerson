using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 3.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = 5;
        _numSeedsPlanted = 0;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)) {
            _playerTransform.Translate(Vector3.down * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A)) {
            _playerTransform.Translate(Vector3.left * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)) {
            _playerTransform.Translate(Vector3.right * _speed * Time.deltaTime);
        }
        if (Input.GetKeyDown("space")) {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        Vector3 playerLocation = _playerTransform.localPosition;
        if (_numSeedsLeft > 0) {
            Instantiate(_plantPrefab, playerLocation, Quaternion.identity);
            _numSeedsLeft--;
            _numSeedsPlanted++;   
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);     
        }
    }
}
