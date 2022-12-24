using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LessonVariable {
    public enum Lessons
    {
        NULL,
        ARCA,
        ACAP,
        SEU,
        MEEGQ,
        SGI,
        CSI,
        TMD,
        PEGTI
    }

    public enum LessonsDuration {
        _14,
        _15,
        _16,
        _17,
        _18,
        _19,
        _20,
    }

    public enum LessonsWeek
    {
        MON,
        TUE,
        WED,
        THU,
        FRI
    }

    public static string LessonsToShortString(Lessons name)
    {
        string res = "lessons";
        switch (name)
        {
            case Lessons.NULL:
                res = " ";
                break;
            case Lessons.ACAP:
                res = "ACAP";
                break;
            case Lessons.ARCA:
                res = "ARCA";
                break;
            case Lessons.CSI:
                res = "CSI";
                break;
            case Lessons.MEEGQ:
                res = "MEEGQ";
                break;
            case Lessons.PEGTI:
                res = "PEGTI";
                break;
            case Lessons.SEU:
                res = "SEU";
                break;
            case Lessons.SGI:
                res = "SGI";
                break;
            case Lessons.TMD:
                res = "TMD";
                break;
        }
        return res;
    }

    public static string LessonsDurationToString(LessonsDuration name)
    {
        string res = "lessons";
        switch (name)
        {
            case LessonsDuration._14:
                res = "14:00 - 15:00";
                break;
            case LessonsDuration._15:
                res = "15:00 - 16:00";
                break;
            case LessonsDuration._16:
                res = "16:00 - 17:00";
                break;
            case LessonsDuration._17:
                res = "17:00 - 18:00";
                break;
            case LessonsDuration._18:
                res = "18:00 - 19:00";
                break;
            case LessonsDuration._19:
                res = "19:00 - 20:00";
                break;
            case LessonsDuration._20:
                res = "20:00 - 21:00";
                break;

        }
        return res;
    }

    public static TimeSpan[] LessonsDurationToDateTime(LessonsDuration name)
    {
        TimeSpan[] res = new TimeSpan[2];
        switch (name)
        {
            case LessonsDuration._14:
                res[0] = new TimeSpan(14,0,0);
                res[1] = new TimeSpan(15,0,0);
                break;
            case LessonsDuration._15:
                res[0] = new TimeSpan(15, 0, 0);
                res[1] = new TimeSpan(16, 0, 0);
                break;
            case LessonsDuration._16:
                res[0] = new TimeSpan(16, 0, 0);
                res[1] = new TimeSpan(17, 0, 0);
                break;
            case LessonsDuration._17:
                res[0] = new TimeSpan(17, 0, 0);
                res[1] = new TimeSpan(18, 0, 0);
                break;
            case LessonsDuration._18:
                res[0] = new TimeSpan(18, 0, 0);
                res[1] = new TimeSpan(19, 0, 0);
                break;
            case LessonsDuration._19:
                res[0] = new TimeSpan(19, 0, 0);
                res[1] = new TimeSpan(20, 0, 0);
                break;
            case LessonsDuration._20:
                res[0] = new TimeSpan(20, 0, 0);
                res[1] = new TimeSpan(21, 0, 0);
                break;

        }
        return res;
    }

    public static string LessonsWeekToString(LessonsWeek name)
    {
        string res = "lessons";
        switch (name)
        {
            case LessonsWeek.MON:
                res = "MON";
                break;
            case LessonsWeek.TUE:
                res = "TUE";
                break;
            case LessonsWeek.WED:
                res = "WED";
                break;
            case LessonsWeek.THU:
                res = "THU";
                break;
            case LessonsWeek.FRI:
                res = "FRI";
                break;


        }
        return res;
    }

    public static DayOfWeek LessonsWeekToDayOfWeek(LessonsWeek name)
    {
        DayOfWeek res = DayOfWeek.Sunday; 
        switch (name)
        {
            case LessonsWeek.MON:
                res = DayOfWeek.Monday;
                break;
            case LessonsWeek.TUE:
                res = DayOfWeek.Tuesday;
                break;
            case LessonsWeek.WED:
                res = DayOfWeek.Wednesday;
                break;
            case LessonsWeek.THU:
                res = DayOfWeek.Thursday;
                break;
            case LessonsWeek.FRI:
                res = DayOfWeek.Friday;
                break;


        }
        return res;
    }

}
