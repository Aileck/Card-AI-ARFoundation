using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathVariable
{
    // Start is called before the first frame update
    public enum PathName {
        LESSONS,
        SYSTEM,
        MAP
    }

    public static string PathToString (PathVariable.PathName name)
    {
        string res = "lessons";
        switch (name) {
            case PathName.LESSONS:
                res = "lessons.yaml";
                break;
            case PathName.SYSTEM:
                res = "system.yaml";
                break;
            case PathName.MAP:
                res = "map.yaml";
                break;
        }
        return res;
    }
}
