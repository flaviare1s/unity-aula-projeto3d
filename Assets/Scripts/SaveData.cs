using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public float lifePlayer = 100f;
    private bool canSave = false;
    private Vector3 lastPositionSave;
    private float lastLifeSave;
    private bool hasDataSaved = false;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.CompareTag("SavePoint"))
        {
            Debug.Log("SavePoint. Pressione s para salvar.");
            canSave = true;
        }
    }
    void Start()
    {
        loadData();
    }

    void Update()
    {
        if (canSave && Input.GetKeyDown(KeyCode.S))
        {
            saveData();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            clearData();
        }
    }

    void saveData()
    {
        lastPositionSave = transform.position;
        lastLifeSave = lifePlayer;
        
        PlayerPrefs.SetFloat("Life", lastLifeSave);
        PlayerPrefs.SetFloat("x", lastPositionSave.x);
        PlayerPrefs.SetFloat("y", lastPositionSave.y);
        PlayerPrefs.SetFloat("z", lastPositionSave.z);
        PlayerPrefs.SetInt("hasDataSaved", 1);

        Debug.Log($"Jogo salvo! Posição: {lastPositionSave}, Vida: {lastLifeSave}");

        PlayerPrefs.Save();
        canSave = false;
    }

    void loadData()
    {
        if (PlayerPrefs.GetInt("hasDataSaved", 0) == 1)
        {
            float x = PlayerPrefs.GetFloat("x");
            float y = PlayerPrefs.GetFloat("y");
            float z = PlayerPrefs.GetFloat("z");
            lastPositionSave = new Vector3(x, y, z);
            lastLifeSave = PlayerPrefs.GetFloat("Life");

            transform.position = lastPositionSave;
            lifePlayer = lastLifeSave;
            hasDataSaved = true;
            Debug.Log($"Jogo carregado! Posição: {lastPositionSave}, Vida: {lastLifeSave}");
        }
        else
        {
            Debug.Log("Nenhum jogo salvo.");
        }
    }

    void clearData()
    {
        PlayerPrefs.DeleteKey("x");
        PlayerPrefs.DeleteKey("y");
        PlayerPrefs.DeleteKey("z");
        PlayerPrefs.DeleteKey("Life");
        PlayerPrefs.DeleteKey("hasDataSaved");
        Debug.Log("Jogo apagado.");

        lastPositionSave = Vector3.zero;
        lastLifeSave = 0f;
        hasDataSaved = false;
    }
}
