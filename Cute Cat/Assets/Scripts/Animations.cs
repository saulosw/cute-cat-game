using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public Animator Animachar;

    public void BtxChamaDance(){

        Animachar.Play("Dance");
    }
    public void BtxChamaBanho(){

    Animachar.Play("Bath");
    }
    public void BtxChamaFeliz(){

    Animachar.Play("Happy");
    }

    public void BtxChamaSono(){

    Animachar.Play("Sleep");
    }
    public void BtxChamaParado(){

        Animachar.Play("Stop");
    }

}
