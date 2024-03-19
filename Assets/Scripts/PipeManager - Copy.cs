using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    public GameObject pipeModel;
    public Transform spawnPoint ;
    public float interval;

    private float currentTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > interval)
        {
            CreatePipe();
            currentTime = 0f;
        }
    }

    void CreatePipe()
    {
        var pipeGameGameObject = Instantiate(pipeModel);
        var pipeTransform = pipeGameGameObject.GetComponent<Transform>();

        float y = Random.Range(-1.6f, 0,26f);

        pipeTransform.position = new Vector3(spawnPoint.position.x, y);
    }
}
