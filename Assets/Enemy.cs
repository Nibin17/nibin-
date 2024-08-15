using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Time_To_Start;
    public float Time_btwn_waves;
    public GameObject Bullet_obj;
    public Transform spawn_pos;
    // Start is called before the first frame update


    private void Start()
    {

    }
    // Update is called once per frame

    void Update()
    {
        Time_To_Start -= Time.deltaTime;
        if (Time_To_Start <= 0)
        {
            Spawn();
            Time_To_Start = Time_btwn_waves;
        }
    }
    public void Spawn()
    {
        Instantiate(Bullet_obj, spawn_pos.position, Quaternion.identity);
    }
}

