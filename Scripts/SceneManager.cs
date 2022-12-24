using System.Collections;
using System.Collections.Generic;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.RepresentationModel;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Dropdown dropdown;
    public SystemVariable.Phase phase = SystemVariable.Phase.SCANNING;
    public SystemVariable.Language language = SystemVariable.Language.CA;

    void Start()
    {

        BetterStreamingAssets.Initialize();
        dropdown.onValueChanged.AddListener(delegate {
            ChangLang(dropdown);
        });
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Application.persistentDataPath);
    }

    public string ReadFromYaml(PathVariable.PathName _path, string _word) {
        string res = "MISSING-WORD";
        string lang = SystemVariable.LangToString(this.language);
        string path = PathVariable.PathToString(_path);

        string yml;
        if (!BetterStreamingAssets.FileExists(@"/Locales/" + lang + @"/" + path))
        {
            Debug.LogErrorFormat("Streaming asset not found: {0}", path);
            return res;
        }
        //if (Application.platform == RuntimePlatform.Android)
        yml = BetterStreamingAssets.ReadAllText(@"/Locales/" + lang + @"/" + path);
        //else 
        //    yml = File.ReadAllText(Application.dataPath + @"\Locales\" + lang + @"\" + path);
        

        var input = new StringReader(yml);

        // Load the stream
        var yaml = new YamlStream();
        yaml.Load(input);

        var mapping = (YamlMappingNode)yaml.Documents[0].RootNode;
        string item = (string)mapping.Children[new YamlScalarNode(_word)];

        if (item != null)
            res = item;

        return res;
    }

    string LangToString(){
        string res = "ca";
        if (language == SystemVariable.Language.CA) {
            res = "ca";
        }
        if (language == SystemVariable.Language.ES)
        {
            res = "es";
        }
        if (language == SystemVariable.Language.EN)
        {
            res = "en";
        }

        return res;
    }

    public void ChangLang(Dropdown change) {
        int _lang = change.value;
        Debug.Log(_lang);
        if (_lang == 0)
            language = SystemVariable.Language.CA;

        if (_lang == 1)
            language = SystemVariable.Language.ES;

        if (_lang == 2)
            language = SystemVariable.Language.EN;


    }


}
