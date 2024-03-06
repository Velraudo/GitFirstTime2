using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
     public float moveSpeed = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Mendapatkan input horizontal (-1 untuk kiri, 1 untuk kanan)
        float horizontalInput = Input.GetAxis("Horizontal");

        // Mendefinisikan pergerakan menggunakan Vector3
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f) * moveSpeed * Time.deltaTime;

        // Menggerakkan pemain
        transform.Translate(movement);
    }
}
