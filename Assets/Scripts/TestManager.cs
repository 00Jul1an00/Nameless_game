using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestManager : MonoBehaviour
{
    [SerializeField] private Dialogue _character;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _character.StartDialog();
        }
    }
}
