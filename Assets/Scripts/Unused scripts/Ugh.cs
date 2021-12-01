using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ugh : MonoBehaviour
{
    
        int health;
        int power;
        string name;
        public Ugh(int a, int b, string c)
        {
            
            health = a;
            power = b;
            name =  c;

        
        }

        public void Printer()
        {
          Debug.Log("health" + health);
          Debug.Log("Power " + power);
          Debug.Log("Name " + name);
        }
    

    
}


/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int health = 100;
    int power = 50;
    string name = "avd";
    public Player(int health, int power, string name)
    {
        // Debug.Log("health"+health);
    }
    /*Debug.Log("Health " + health);
    Debug.Log("Power " + power);
    Debug.Log("Name " + name);*/
    /*public Player(int health, int power, string name);
    {
        this.health = health;
        this.power = power;
        this.name =  name;

        Debug.Log("Health " + health);
        Debug.Log("Power " + power);
        Debug.Log("Name " + name);
    }
    
}*/

