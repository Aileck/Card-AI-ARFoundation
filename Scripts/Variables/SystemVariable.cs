

public class SystemVariable
{
    public enum Language {
        CA,
        ES,
        EN
    }

    public enum Phase {
        SCANNING,
        SCANNED_FRONT,
        SCANNED_BACK
    }

    public static string LangToString(Language name)
    {
        string res = "ca";
        switch (name)
        {
            case Language.CA:
                res = "ca";
                break;
            case Language.ES:
                res = "es";
                break;
            case Language.EN:
                res = "en";
                break;
        }
        return res;
    }

}
