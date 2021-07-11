using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(menuName = "ScriptableObjects/AudioManager")]
public class SoundManager : ScriptableObject
{
    [SerializeField] private AudioClip shootClip;
    [SerializeField] private AudioClip sheepHitClip;
    [SerializeField] private AudioClip sheepDropClip;
    [SerializeField] private AudioClip tractorMoveClip;
    [SerializeField] private AudioClip ButtonClip;

    [SerializeField] private Vector3 cameraPostion;

    //private void OnEnable()
    //{
    //    cameraPostion = Camera.main.transform.position;
    //}

    private void PlaySound(AudioClip audioClip)
    {
        cameraPostion = Camera.main.transform.position;
        AudioSource.PlayClipAtPoint(audioClip, cameraPostion);
    }

    public void PlayShootClip()
    {
        PlaySound(shootClip);
    }
    public void PlaySheepHitClip()
    {
        PlaySound(sheepHitClip);
    }
    public void PlayDropClip()
    {
        PlaySound(sheepDropClip);
    }
    public void PlaytractorMoveClip()
    {
        PlaySound(tractorMoveClip);
    }

    public void PlayButtonClip()
    {
        PlaySound(ButtonClip);
    }
}
