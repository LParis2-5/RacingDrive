using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IsSavable
{

    void load(object s);

    object save();
  


}
