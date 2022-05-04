using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionComparer : IComparer<LapController>
{
    public int Compare(LapController x, LapController y)
    {
        return x.lapValue.CompareTo(y.lapValue);
    }
}
