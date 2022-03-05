using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    
    public int spheres=0; //Собранные сфера

    public event UnityAction<int> CollectedSpheres; //Событие сбора сфер
    public event UnityAction Wins; //Событие выйграша уровня


    //Прочедура сбора сфер
    public void ApplySpheres(int count)
    {
        spheres += 1;
        CollectedSpheres.Invoke(spheres);

        if (spheres == 5)
        {
            GameWin();
        }
    }

    private void GameWin()
    {
        Wins?.Invoke();
    }

   

   

}
