using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour
{
    private AudioSource _audioSource;

    [SerializeField] private GameObject panel;
    private Image _test;
    private bool _flag;
    private bool aaa;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _test = panel.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (aaa)
        {
            _test.fillAmount += 0.05f;
            _audioSource.volume += 0.01f;
        }
        else
        {
            _audioSource.volume -= 0.01f;
            _test.fillAmount -= 0.05f;
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        aaa = true;
        if (!_flag)
        {
            _audioSource.Play();
            _flag = true;
        }
        else
        {
            _audioSource.UnPause();
        }
        Debug.Log("テスト");
    }

    private void OnTriggerExit(Collider other)
    {
        aaa = false;
        _audioSource.Pause();
    }
}
